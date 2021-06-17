import React, {Component, useState, useEffect} from 'react';
import ReactDOM from 'react-dom';
import Container from "react-bootstrap/Container";
import 'react-bootstrap-table2-filter/dist/react-bootstrap-table2-filter.min.css'
import Tabs from "react-bootstrap/Tabs";
import {Tab, Row, Col, Button} from "react-bootstrap";
import RentTable from "./components/RentTable";
import ReportsTable from "./components/ReportsTable";
import ServiceReportsTable from "./components/ServiceReportsTable";
import { useLocation } from 'react-router-dom';
import './CarManagementInfoStyle.css';
import ConditionReportModalWindow from'./components/ConditionReportModalWindow';
function CarManagerInfo (props){
    var location = useLocation();
    // constructor(props) {
    //     super(props);
        // if (this.props.location?.state?.CarId !== null) {
        //     this.state = {CarId: this.props.location?.state?.CarId,brand: "Ravon", model: "R2 R330", winCode:"Win356917M"};
        // } else {
        //     this.state = {CardId: 0}
        // }

    // }
    const [isShown, setShow] = useState(false);
    const [carData, setCar] = useState(null);

    useEffect(()=>{
        if (location?.state?.CarId !== null) {
                setCar({CarId: location?.state?.CarId,brand: "Ravon", model: "R2 R330", winCode:"Win356917M"});
            } else {
                setCar({CardId: 0});
            }
    }, [setCar]);
    return(
            <Container fluid={true} className={"px-lg-3 px-md-3 px-sm-1 px-xl-5 px-xxl-5 pt-3 mx-0 bg-light "}>
                <Row>
                    <Col md={6}>
                        <h3>{carData?.brand} {carData?.model}</h3>
                        <p className={"text-secondary"}>{carData?.winCode}</p>
                    </Col>
                    <Col md={6} className = "text-right h-100">
                        <Button id = "button-generate" onClick = {()=>{setShow(true)}}>Generate Report</Button>
                    </Col>
                </Row>
                
                <Tabs >
                    <Tab title={"Rents"} eventKey={"rents"}>
                        <RentTable/>
                    </Tab>
                    <Tab title={"Reports"} eventKey={"reports"} >
                        <ReportsTable/>
                    </Tab>
                    <Tab title={"Services"} eventKey={"services"}>
                        <ServiceReportsTable/>
                    </Tab>
                </Tabs>
                <ConditionReportModalWindow carid = {carData?.CarId}
                show = {isShown}            
                onHide = {()=>setShow(false)}
            />
            </Container>);
}

export default CarManagerInfo;