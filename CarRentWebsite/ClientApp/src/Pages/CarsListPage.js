import React, {useEffect, useRef, useState} from 'react';
import { useHistory } from "react-router-dom";
import { Container, Table, Button } from 'react-bootstrap';
import Service from '../services/CarsListService';
import "./CarsListPageStyle.css"
//import ConditionReportModalWIndow from "../components/ConditionReportModalWindow";
//TODO implement json
function CarsListPage(){

    const [cars, setCars] = useState({
        isLoading: true,
        carsData: null
    });
    const [isShown, setShow] = useState(false);
    var selectedCarId = 1;
    var history = useHistory();
    useEffect(()=>{
        Service.getCarsList().then((responce)=>{
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
        selectedCarId = rowData.CarId;
        //selectedCarId = 1;
        //console.log(selectedCarId);
        //history.push('');
        //TODO implement navigation to Car details page
        //setShow(true);
    }

    const rows = ()=>{
        var json = {"CarId": "1"};
        if(cars.cars && cars.cars.length > 0){
        return (cars.cars.map((car) => (<tr onDoubleClick ={onRowClicked(car)}><td>1</td>
            <td>{car.Brand.Name}</td>
            <td>Cerato</td>
            <td>2002</td>
            <td>100</td>
            <td>АХ 2021 ВС</td>
            <td>123456</td>
            <td>in use</td></tr>)));}
        else return (<tr onDoubleClick={()=>onRowClicked(json)}>
            <td>1</td>
            <td>Kia</td>
            <td>Cerato</td>
            <td>2002</td>
            <td>100</td>
            <td>АХ 2021 ВС</td>
            <td>123456</td>
            <td>in use</td>
        </tr>)
    }
    return(
        <Container className ="text-center">
            <h2 id="header">Cars List</h2>
            <Table bordered hover responsive >
                <thead>
                    <tr>
                        <th>№</th>
                    <th>Brand</th>
                    <th>Model</th>
                    <th>Year</th>
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