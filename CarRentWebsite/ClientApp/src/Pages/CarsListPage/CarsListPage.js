import React, {useEffect, useRef, useState} from 'react';
import { Container, Table, Button } from 'react-bootstrap';
import "./CarsListPageStyle.css"
import { useHistory } from 'react-router-dom';
import http from "../../http-common";
//import ConditionReportModalWIndow from "../components/ConditionReportModalWindow";
//TODO implement json
function CarsListPage(){
    let history = useHistory();
    const [cars, setCars] = useState({
        isLoading: true,
        carsData: null
    });
    var selectedCarId = 1;
    useEffect(()=>{
        http.get("/Cars").then((responce)=>{
            var data = responce.data;
            if(data != null){
                setCars({isLoading: false, carsData: data});
            }
            else{
                setCars({isLoading: false, carsData: Array.from(data)});
            }
        }).catch(e=>{
            setCars({isLoading: false, carsData: null})
            console.log(e);
        });
        console.log(typeof(cars.cars));
    }, [setCars]);

    const onRowClicked = (rowData)=>{
        selectedCarId = rowData.id;
        history.replace({
            pathname: "/manager/cars/"+selectedCarId,
            state: {CarId: selectedCarId}
        });
        //selectedCarId = 1;
        //console.log(selectedCarId);
        //history.push('');
        //TODO implement navigation to Car details page
        //setShow(true);
    }
    const DateParcer = (date)=>{
        var data = new Date(date);
        var stringDate =  data.toLocaleDateString('en-GB');
        return stringDate;
    }
    const rows = ()=>{
        var json = {"CarId": "1"};
        if(cars?.carsData && cars?.carsData?.length > 0){
        return (cars.carsData.map((car) => (<tr onDoubleClick ={()=>onRowClicked(car)}>
            <td>{car.id}</td>
            <td>{car.brand.name}</td>
            <td>{car.model?? "model"}</td>
            <td>{DateParcer(car.registerDate)}</td>
            <td>{car.kilometersDriven ?? 1000}</td>
            <td>{car.registerNumber}</td>
            <td>{car.engine.winCode}</td>
            <td>{car.carStatus.name}</td></tr>)));}
        else return (<tr></tr>);
         //else return  (<tr onDoubleClick={()=>onRowClicked(json)}>
        //     <td>1</td>
        //     <td>Kia</td>
        //     <td>Cerato</td>
        //     <td>2002</td>
        //     <td>100</td>
        //     <td>АХ 2021 ВС</td>
        //     <td>123456</td>
        //     <td>in use</td>
        // </tr>)
    }
    return(
        <Container className ="text-center style">
            <h2 id="header">Cars List</h2>
            <Table bordered hover responsive >
                <thead>
                    <tr>
                        <th>№</th>
                    <th>Brand</th>
                    <th>Model</th>
                    <th>RegistrationDate</th>
                    <th>Mileage (km)</th>
                    <th>Car number</th>
                    <th>WIN number</th>
                    <th>Status</th>
                    </tr>
                    
                </thead>
                <tbody>
                    {rows()}
                    {/* <tr></tr> */}
                </tbody>
            </Table>
            <Button variant ="secondary" size="md" block className = "buttonStyle">Add new car</Button>
            {/* <ConditionReportModalWIndow carid = {selectedCarId}
                show = {isShown}            
                onHide = {()=>setShow(false)}
            /> */}
        </Container>
    );
}
export default CarsListPage;