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
        this.state={carId:this.props.match.params.id};
        console.log(this.props.match.params.id)
    }
    render() {
        return(
            <Container fluid={true} className={"m-0 p-0"}>
                <CarBaseInfo carId={this.state.carId}/>
                <AdditionalOptions/>
                <Comments carId={this.state.carId}/>
                <SimilarCars carId={this.state.carId}/>
            </Container>)
    }
}

