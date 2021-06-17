import React, {useState, useEffect, useContext} from 'react';
import './AppUserPageStyle.css';
import {RiUserLine} from 'react-icons/ri';
import {Container, Row, Col, Button} from 'react-bootstrap';
import UserCarsInfoTemplate from '../../components/UserCarsInfoTemplate'
import http from '../../http-common';
import {useHistory, useLocation } from "react-router-dom";
import UserContext from '../../UserContext';
// var personInfo = {
//     "Name": "Andrii",
//     "Surname": "Harashchak",
//     "Email": "abc@abc.abc",
//     "Role": {
//       "RoleId": "0",
//       "Name": "Manager"
//     }
//   };
var json = [{
     "Price": "1800",
     "BeginDate": "2020-01-01",
     "EndDate": "2021-05-07"
}, { "Price": "1800",
    "BeginDate": "2020-01-01",
    "EndDate": "2021-05-07"}];

function AppUserPage(props){
    //var history = null;
    //var active= null;
    const location = useLocation();
    var history = useHistory();
    var personId = location.state.personId;
    const [userRentInfo, setUserRentInfo] = useState(null);
    const [userInfo, setUserInfo] = useState(null);
    var personInfo = useContext(UserContext);
    useEffect(()=>{
        // http.get("/user/" + personId).then((responce)=>{
            //     const data = responce.data;
            //     setUserInfo(data);
            // }).catch(e=>{
            //     console.log(e);
            // });
            setUserInfo(personInfo);
    }, [setUserInfo]);

    useEffect(()=>{
        if(userInfo?.Role?.RoleId == 1){
            // http.get("").then((responce)=>{
            //     const data = responce.data;
            //     setUserRentInfo(data);
            // }).catch(e=>{
            //     console.log(e);
            // });
            setUserRentInfo(json);
        }
    });

    const getActiveRents = ()=>{
        if(userRentInfo != null){
            return userRentInfo.map((unit)=>(<UserCarsInfoTemplate data={unit}/>))
        }else{
            return <Container/>;
        }
    }

    function getContent () {
        if(userInfo?.Role?.RoleId == 1){
            return (
            <Container fluid>
                <h1 className = "header">Rented cars</h1>
                {getActiveRents()}
                <h1 className = "header">Rents history</h1>
                <UserCarsInfoTemplate/>
            </Container>
            );
        }
        else if(userInfo?.Role?.RoleId == 0){
            return <Container fluid>
                    <Button variant="secondary" id ="buttonStyle" onClick = {() =>history.push({
                        pathname: '/manager/cars'
                    })}>Cars page</Button>
                    <Button variant="secondary" id ="buttonStyle" style ={{marginTop : "0"}} onClick = {() =>history.push({
                        pathname: '/manager/rents'
                    })}>Rents page</Button>
            </Container>
        }
        else if(userInfo?.Role?.RoleId == 2){
            return <Container>
                    <Button variant="secondary" id ="buttonStyle" onClick = {()=>history.push({
                        pathname: '/service'
                    })}>Service tasks page</Button>
            </Container>
        }
    }
    if(userInfo!= null)
    return(
        <Container className = 'col-md-8 col-sm-12 mt-5 text-center'>
            <h1 className = "header">User info </h1>
            <Container>
                <Row className = 'pageStyle'>
                <Col md={3} >
                    <RiUserLine size = '200px'/>
                </Col>
                <Col md={9} className = 'my-auto'>
                    <div className = ' h-100'>
                        <h3 className ="textStyle">Name: {userInfo?.Surname ?? "" + ' ' + userInfo?.Name ?? ""}</h3>
                        <h3 className = "textStyle">Email: {userInfo?.Email ?? ""}</h3>
                        <h3 className="textStyle">Position: {userInfo?.Role?.Name ?? ""}</h3>
                    </div>
                </Col>
            </Row>
            </Container>
        
        {getContent()}
        {/* <h1 className = "header">Rented cars</h1>
            {getActiveRents()}
        <h1 className = "header">Rents history</h1>
            <UserCarsInfoTemplate/> */}
        </Container>
        
    );
    else return (<Container className="text-center">
        <h1>Cant` receive data about user</h1>
    </Container>)
}

export default AppUserPage;