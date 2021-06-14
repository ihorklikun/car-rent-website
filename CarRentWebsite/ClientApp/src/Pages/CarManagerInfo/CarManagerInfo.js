import React, {Component} from 'react';
import ReactDOM from 'react-dom';
import Container from "react-bootstrap/Container";
import 'react-bootstrap-table2-filter/dist/react-bootstrap-table2-filter.min.css'
import Tabs from "react-bootstrap/Tabs";
import Tab from "react-bootstrap/Tab";
import RentTable from "./components/RentTable";
import ReportsTable from "./components/ReportsTable";
import ServiceReportsTable from "./components/ServiceReportsTable";
export default class CarManagerInfo extends Component{
    constructor(props) {
        super(props);
        if (this.props.CarId !== null) {
            this.state = {CarId: this.props.CarId,brand: "Ravon", model: "R2 R330", winCode:"Win356917M"};
        } else {
            this.state = {CardId: 0}
        }
    }
    render(){
        return(
            <Container fluid={true} className={"px-lg-3 px-md-3 px-sm-1 px-xl-5 px-xxl-5 pt-3 mx-0 bg-light "}>
                <h3>{this.state.brand} {this.state.model}</h3>
                <p className={"text-secondary"}>{this.state.winCode}</p>
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
            </Container>);
    }
}