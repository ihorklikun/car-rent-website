import React, {Component} from 'react';
import ReactDOM from 'react-dom';
import Container from "react-bootstrap/Container";
import 'react-bootstrap-table2-filter/dist/react-bootstrap-table2-filter.min.css'
import Tabs from "react-bootstrap/Tabs";
import Tab from "react-bootstrap/Tab";
import RentTable from "./components/RentTable";
import ReportsTable from "./components/ReportsTable";
import ServiceReportsTable from "./components/ServiceReportsTable";
import http from "../http-common";
export default class CarManagerInfo extends Component{
    constructor(props) {
        super(props);
        if (this.props.match.params.id !== null) {
            this.state = {carId:this.props.match.params.id ,brand: "Ravon", model: "R2 R330", winCode:"Win356917M",car:null};
        } else {
            this.state = {carId:0,brand: "Ravon", model: "R2 R330", winCode:"Win356917M",car:null}
        }
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
                <h3>{this.state.brand} {this.state.model}</h3>
                <p className={"text-secondary"}>{this.state.winCode}</p>
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
            </Container>);
    }
}