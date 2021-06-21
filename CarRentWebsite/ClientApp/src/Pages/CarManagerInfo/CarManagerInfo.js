import React, {Component} from 'react';
import ReactDOM from 'react-dom';
import Container from "react-bootstrap/Container";
import 'react-bootstrap-table2-filter/dist/react-bootstrap-table2-filter.min.css'
import Tabs from "react-bootstrap/Tabs";
import Row from "react-bootstrap/Row"
import Col from "react-bootstrap/Col"
import {Button} from "react-bootstrap";
import Tab from "react-bootstrap/Tab";
import RentTable from "./components/RentTable";
import ReportsTable from "./components/ReportsTable";
import ServiceReportsTable from "./components/ServiceReportsTable";
import http from '../../http-common'
import ConditionReportModalWindow from "./components/ConditionReportModalWindow";
export default class CarManagerInfo extends Component{
    constructor(props) {
        super(props);
        if (this.props.match.params.id !== null) {
            this.state = {carId:this.props.match.params.id ,brand: "Ravon", model: "R2 R330", winCode:"Win356917M",car:null,show:false};
        } else {
            this.state = {carId:0,brand: "Ravon", model: "R2 R330", winCode:"Win356917M",car:null,show:false}
        }
        this.handleShow=this.handleShow.bind(this);
        this.handleHide=this.handleHide.bind(this);
    }
    handleShow(){
        this.setState(state=>({
            show:true
        }))
    }
    handleHide(){
        this.setState(state=>({
            show:false
        }))
    }
    componentDidMount() {
        console.log(this.state);
        if(this.state.carId) {
            http.get("./Cars/" + this.state.carId).then((responce)=> {
                const data = responce.data;
                this.setState(state=>({
                    car: data,
                    brand: data.brand.name,
                    model: data.registerNumber,
                    winCode: data.engine.winCode
                }))
                console.log(this.state);
            }).catch(error=>{
                this.setState(state=>({car:null}))
                console.log(error);
            });
        }
    }
    render(){
        return(
            <Container fluid={true} className={"px-lg-3 px-md-3 px-sm-1 px-xl-5 px-xxl-5 pt-3 mx-0 bg-light "}>
                <Row>
                    <Col md={6}>
                        <h3>{this.state.brand} {this.state.model}</h3>
                        <p className={"text-secondary"}>{this.state.winCode}</p>
                    </Col>
                    <Col md={6} className = "text-right h-100">
                        <Button id = "button-generate" onClick = {this.handleShow}>Generate Report</Button>
                    </Col>
                </Row>
                <Tabs >
                    <Tab title={"Rents"} eventKey={"rents"}>
                        <RentTable CarId={this.state.CarId}/>
                    </Tab>
                    <Tab title={"Reports"} eventKey={"reports"} >
                        <ReportsTable CarId={this.state.CarId}/>
                    </Tab>
                    <Tab title={"Services"} eventKey={"services"}>
                        <ServiceReportsTable CarId={this.state.CarId}/>
                    </Tab>
                </Tabs>
                <ConditionReportModalWindow carid = {this.state.CarId}
                                            show = {this.state.show}
                                            onHide = {this.handleHide}
                />
            </Container>);
    }
}