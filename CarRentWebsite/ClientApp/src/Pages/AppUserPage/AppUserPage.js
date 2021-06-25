import React, { useState, useEffect, useContext } from 'react';
import './AppUserPageStyle.css';
import { RiUserLine } from 'react-icons/ri';
import { Container, Row, Col, Button } from 'react-bootstrap';
import UserCarsInfoTemplate from '../../components/UserCarsInfoTemplate'
import http from '../../http-common';
import { useHistory, useLocation } from "react-router-dom";
// var personInfo = {
//     "Name": "Andrii",
//     "Surname": "Harashchak",
//     "Email": "abc@abc.abc",
//     "Role": {
//       "RoleId": "0",
//       "Name": "Manager"
//     }
//   };
var rent = [{
    "id": 0,
    "beginDate": "2021-06-20T13:12:54.424Z",
    "endDate": "2021-06-25T13:12:54.424Z",
    "price": 0,
    "rentStatus": {
        "id": 0,
        "name": "string"
    },
    "car": {
        "id": 0,
        "registerNumber": "AA 2021 BC",
        "registerDate": "2021-06-23",
        "description": "string",
        "imageUrl": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBjOLV4oC85vIevarurD4-EoGNKKyqKVY74w&usqp=CAU",
        "seatsCount": 0,
        "trunkSize": 0,
        "model": "S63",
        "kilometersDriven": 0,
        "brand": {
            "id": 0,
            "name": "Mersedes"
        },
        "location": {
            "id": 0,
            "cityId": 0,
            "city": {
                "id": 0,
                "name": "string"
            },
            "street": "string",
            "building": "string"
        },
        "fuel": {
            "id": 0,
            "name": "string"
        },
        "engine": {
            "id": 0,
            "name": "string",
            "fuelCapacity": 0,
            "power": 0,
            "torque": 0,
            "winCode": "string"
        },
        "transmission": {
            "id": 0,
            "name": "string"
        },
        "carStatus": {
            "id": 0,
            "name": "string"
        },
        "carType": {
            "id": 0,
            "name": "string"
        },
        "carClass": {
            "id": 0,
            "name": "string"
        },
        "carPrices": [
            {
                "id": 0,
                "daysCount": 0,
                "price": 0
            }
        ]
    },
    "additionalOptions": [
        {
            "id": 0,
            "name": "string",
            "price": 0
        }
    ]
}];
var json = [{
    "Price": "1800",
    "BeginDate": "2020-01-01",
    "EndDate": "2021-05-07"
}, {
    "Price": "1800",
    "BeginDate": "2020-01-01",
    "EndDate": "2021-05-07"
}];

function AppUserPage(props) {
    //var history = null;
    //var active= null;
    const location = useLocation();
    var history = useHistory();
    var personId = location.state.personId;
    const [userRentInfo, setUserRentInfo] = useState(null);
    const [userInfo, setUserInfo] = useState(null);

    useEffect(() => {
        // http.get("/user/" + personId).then((responce)=>{
        //     const data = responce.data;
        //     setUserInfo(data);
        // }).catch(e=>{
        //     console.log(e);
        // });
        var personInfo = localStorage.getItem("currentUser");
        var data = JSON.parse(personInfo);
        //console.log(personInfo);
        setUserInfo(data);

        if (data.roleId == 1) {
            http.get("http://localhost:25094/rents/user/" + data.id).then((responce)=>{
                 const data = responce.data;
                 setUserRentInfo(data);
             }).catch(e=>{
                 console.log(e);
             });
            //setUserRentInfo(rent);
        }
    }, [setUserInfo]);

    useEffect(() => {
        //if (userInfo.roleId == 1) {
        //    // http.get("/Rents").then((responce)=>{
        //    //     const data = responce.data;
        //    //     setUserRentInfo(data);
        //    // }).catch(e=>{
        //    //     console.log(e);
        //    // });
        //    setUserRentInfo(rent);
        //}
    });

    const getActiveRents = () => {
        if (userRentInfo != null) {
            return userRentInfo.map((unit) => {
                var dateEnd = new Date(unit.endDate);
                var date = new Date();
                if (dateEnd > date)
                    return (<UserCarsInfoTemplate data={unit} key={unit.id} />);
                else return null
            })
        } else {
            return <Container />;
        }
    }
    const getRentsHistory = () => {
        if (userRentInfo != null) {
            return userRentInfo.map((unit) => {
                var dateEnd = new Date(unit.endDate);
                var date = new Date();
                if (dateEnd < date)
                    return (<UserCarsInfoTemplate data={unit} key={unit.id} />);
                else return null;
            })
        } else {
            return <Container />;
        }
    }
    function getContent() {
        if (userInfo?.roleId == 1) {
            return (
                <Container fluid>
                    <h1 className="header">Rented cars</h1>
                    {getActiveRents()}
                    <h1 className="header">Rents history</h1>
                    {getRentsHistory()}
                </Container>
            );
        }
        else if (userInfo?.roleId == 0) {
            return <Container fluid>
                <Button variant="secondary" id="buttonStyle" onClick={() => history.push({
                    pathname: '/manager/cars'
                })}>Cars page</Button>
                <Button variant="secondary" id="buttonStyle" style={{ marginTop: "0" }} onClick={() => history.push({
                    pathname: '/manager/rents'
                })}>Rents page</Button>
                <Button variant="secondary" id="buttonStyle" style={{ marginTop: "0" }} onClick={() => history.push({
                    pathname: '/manager/users'
                })}>Users page</Button>
            </Container>
        }
        else if (userInfo?.roleId == 2) {
            return <Container>
                <Button variant="secondary" id="buttonStyle" onClick={() => history.push({
                    pathname: '/service'
                })}>Service tasks page</Button>
            </Container>
        }
    }
    if (userInfo != null)
        return (
            <Container className="text-center">
                <h1 className="header">User info </h1>
                <Container>
                    <Row className='pageStyle'>
                        <Col md={3} >
                            <RiUserLine size='200px' />
                        </Col>
                        <Col md={9} className='my-auto'>
                            <div className=' h-100'>
                                <h3 className="textStyle">Name: {userInfo?.surname ?? "" + ' ' + userInfo?.name ?? ""}</h3>
                                <h3 className="textStyle">Email: {userInfo?.email ?? ""}</h3>
                                <h3 className="textStyle">Position: {userInfo?.roleName ?? ""}</h3>
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