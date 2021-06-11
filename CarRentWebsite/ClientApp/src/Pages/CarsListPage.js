import React, {useEffect, useState} from 'react';
import { Container, Table, Button } from 'react-bootstrap';
import Service from '../services/CarsListService';
import "./CarsListPageStyle.css"
function CarsListPage(){

    const [cars, setCars] = useState({
        isLoading: true,
        carsData: null
    });
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
        console.log("some data");
    }

    const rows = ()=>{
        if(cars.cars && cars.cars.length > 0)
        return (cars.cars.map((car) => (<tr onClick ={onRowClicked(car)}></tr>)));
        else return (<tr onClick={()=>onRowClicked(null)}>
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
            <Table bordered hover responsive>
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
        </Container>
    );
}
export default CarsListPage;