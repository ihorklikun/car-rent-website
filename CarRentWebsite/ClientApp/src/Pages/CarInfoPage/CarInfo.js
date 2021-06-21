import React, {Component} from 'react';
import ReactDOM from 'react-dom';
import CarBaseInfo from './component/CarInfoComponent'
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/css/bootstrap.css';
import AdditionalOptions from "./component/AdditionalOptions";
import Comments from "./component/Comments";
import SimilarCars from "./component/SimilarCars";
import Container from "react-bootstrap/Container";

export default class CarInfo extends Component{
    constructor(props) {
        super(props);
    }
    render() {
        return(
            <Container fluid={true} className={"m-0 p-0"}>
                <CarBaseInfo name={"Ravon R2 R330"}/>
                <AdditionalOptions/>
                <Comments/>
                <SimilarCars/>
            </Container>)
    }
}

