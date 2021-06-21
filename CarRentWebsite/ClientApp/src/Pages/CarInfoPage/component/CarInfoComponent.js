import React, {useState} from 'react';
import ReactDOM from 'react-dom';
import Rating from '@material-ui/lab/Rating'
import Container from 'react-bootstrap/Container'
import Coll from 'react-bootstrap/Col'
import Row from 'react-bootstrap/Row'
import http from '../../../http-common'
import 'react-bootstrap/'
import ListGroup from "react-bootstrap/ListGroup";
import Alert from "react-bootstrap/Alert";
import Carousel from "react-bootstrap/Carousel"
import CarouselItem from "react-bootstrap/CarouselItem";
import FiveStarsMark from "./FiveStarsMark";
import Image from "react-bootstrap/Image"
import RavonR2_1 from "./Resource/Images/Cars/RavonR2_1.jpg"
import RavonR2_2 from "./Resource/Images/Cars/RavonR2_2.jpg"
import RavonR2_3 from "./Resource/Images/Cars/RavonR2_3.jpg"
import RavonR2_4 from "./Resource/Images/Cars/RavonR2_4.jpg"
import fuelCapacity from  "./Resource/Images/Icons/FuelCapacity.png"
import fuelPerKilometers from  "./Resource/Images/Icons/fuelPerKilometrs.png"
import motor from  "./Resource/Images/Icons/motor.png"
import engine from  "./Resource/Images/Icons/engine.png"
import seatsCount from  "./Resource/Images/Icons/SeatsCount.png"
import transmition from  "./Resource/Images/Icons/transmition.png"
import trunkSize from  "./Resource/Images/Icons/TrunkSize.png"
import carClass from "./Resource/Images/Icons/carClass.png"
import carType from "./Resource/Images/Icons/carType.png"
import Button from "react-bootstrap/Button";
import Card from "react-bootstrap/Card";
const carImages=[{car:RavonR2_1},{car:RavonR2_2},{car:RavonR2_3},{car:RavonR2_4}]
const costs=[{Time:"30 day+",Cost:"30"},{Time:"8 day+",Cost:"40"},{Time:"3-7 day",Cost:"50"},{Time:"1-2 day",Cost:"100"}]
function CostCart(props){
    return(
     <Card bg={"secondary"} border={"dark"} className={"m-0"} style={{maxWidth: "8rem ", minWidth:"3rem"}}>
         <Card.Header className={"text-center px-0"}>
             {props.Period}
         </Card.Header>
         <Card.Body className={"py-0 px-0"}>
             <p className={"text-center"}>{props.Cost}$/day</p>
         </Card.Body>
     </Card>
    )
}
function ParametrCard(props){
    return (
        <Card border={"light"} bg={"light"} className={"py-0 px-0 mx-0 "}  style={{maxWidth: "6rem ", minWidth:"4rem"}}>
          <Card.Img variant={"top"} src={props.SVG} alt={"Prop"} className={"mx-auto d-flex"} style={{maxWidth: "3rem ", minWidth:"3rem"}}  ></Card.Img>
            <Card.Body className={"pt-1 pb-0 px-0 justify-content-center"} >
            <h5 className={"text-center"}>{props.value}</h5>
            </Card.Body>
        </Card>)
}
function CarImageCarousel(props){
    const [index,setIndex]=useState(0);
    const handleSelect = (selectedIndex, e) => {
        setIndex(selectedIndex);
    };
    return (<Carousel className={"xl bg-light"} variant={"dark"} indicators={true}   interval={3000} slide={true} touch={true} activeIndex={index} onSelect={handleSelect} >
            {props.imgArray.map((img,index)=>{return(
                <Carousel.Item >
                    <Image  fluid={true} className={"img-responsive center-block w-100"} alt={"Car1"} src={img.car} ></Image>
                </Carousel.Item>)})}
        </Carousel>
    );
}
function CarFullName(props){
    return <h3 className={"fs-1 pb-0 mb-0 fw-bold"}>{props.brand} {props.model} </h3>
}
export default class CarBaseInfo extends React.Component{
    constructor(props) {
        super(props);
        const basecost=20;
        let cars=require('./jsonData/Car.json');
        let comments=require('./jsonData/Comments.json')
        comments=comments.filter(comment=>comment.CarId==this.props.carId)
        let mark=0;
        comments.map((comment,index)=>{
            mark+=comment.Mark;
        })
        mark=mark/comments.length;
        console.log(cars);
        const car=cars.find(car=>car.CarId==this.props.carId);
        this.state={car:null,carId:this.props.carId,mark:mark,valute:"$",params:[
            {
                name : "carClass",
                icon : carClass,
                value:"5"
                },
                {
                    name : "carType",
                    icon : carType,
                    value:"yes"
                },
                {
                    name : "fuelCapacity",
                    icon : fuelCapacity,
                    value:"100"
                },
                {
                    name : "engine",
                    icon : motor,
                    value: "1.3"
                },{
                    name : "fuel",
                    icon : fuelPerKilometers,
                    value: "10"
                },
                {
                    name : "seatsCount",
                    icon : seatsCount,
                    value: "5"
                },
                {
                    name :  "transmission",
                    icon :  engine,
                    value: "Auto"
                },{
                    name : "trunkSize",
                    icon : trunkSize,
                    value: "200l"
                }]};
        console.log(mark);
        console.log(car);
    }
    componentDidMount(){
        if(this.state.carId) {
            http.get("./Cars/" + this.state.carId).then((responce)=>{
                const data = responce.data;
                if(data != null){
                    const params=[
                        {
                            name : "carClass",
                            icon : carClass,
                            value: data.carClass.name
                        },
                        {
                            name : "carType",
                            icon : carType,
                            value: data.carType.name
                        },
                        {
                            name : "fuelCapacity",
                            icon : fuelCapacity,
                            value: data.engine.fuelCapacity
                        },
                        {
                            name : "engine",
                            icon : motor,
                            value: data.engine.name
                        },{
                            name : "fuel",
                            icon : fuelPerKilometers,
                            value: data.fuel.name
                        },
                        {
                            name : "seatsCount",
                            icon : seatsCount,
                            value: data.seatsCount
                        },
                        {
                            name :  "transmission",
                            icon :  engine,
                            value: data.transmission.name
                        },{
                            name : "trunkSize",
                            icon : trunkSize,
                            value: data.trunkSize
                        }]
                    this.setState(state=>({
                        car:data,params:params
                    }))

                }else{
                    this.setState(state=>({
                        car:Array.from(data)
                    }))
                }
                console.log(data);
            }).catch(error=>{
                this.setState(state=>({car:null}))
                console.log(error);
            });
        }
    }
    render() {
        if(this.state.car) {
            return (
                <Container fluid={true} className={"px-lg-3 px-md-3 px-sm-1 px-xl-5 px-xxl-5 pt-3 mx-0 bg-light "}>
                    <Row>
                        <Coll>
                            <CarFullName brand={this.state.car.brand.name} model={this.state.car.registerNumber}/>
                        </Coll>
                    </Row>
                    <Row>
                        <Coll>
                            <FiveStarsMark mark={this.state.mark}></FiveStarsMark>
                        </Coll>
                    </Row>
                    <Row className={"pt-2"}>
                        <Coll xxl={4} xl={5} lg={6} md={7} sm={12} xs={12} className={" "}>
                            <CarImageCarousel imgArray={carImages}></CarImageCarousel>
                        </Coll>
                        <Coll xxl={8} xl={7} lg={6} md={5} sm={12} xs={12}
                              className={"pl-lg-5 pl-md-5 pl-sm-5 pl-xs-5 "}>
                            <Row className={"pt-2"}>
                                <Coll xxl={7} xl={7} lg={6} md={6} sm={5} xs={6} className={"pr-0"}>
                                    <h3>from 30{this.state.valute}/day </h3>
                                </Coll>
                                <Coll className={"pl-0 pr-4"}>
                                    <Button block={true} variant={"warning"} size={"lg"}>Book a car </Button>
                                </Coll>
                            </Row>
                            <Row lg={4} xxl={4} xl={4} md={4} sm={4} xs={4}
                                 className={"pt-3 g-lg-2 g-xxl-2 g-md-1 g-sm-1 px-0 justify-content-center "}>
                                {costs.map((cost, index) => {
                                    return (
                                        <Coll><CostCart Period={cost.Time} Cost={cost.Cost}/></Coll>
                                    )
                                })}
                            </Row>
                            <Row lg={4} xxl={8} xl={4} md={3} sm={4} xs={4}
                                 className={"gx-lg-4 gx-xxl-5 gx-md-3 gx-sm-1 gx-xs-1 gy-3 pr-0   mb-0 mt-2 justify-content-center  d-flex px-auto"}>
                                {this.state.params.map((param, index) => {
                                    return (
                                        <Coll className={""}><ParametrCard SVG={param.icon} value={param.value}/></Coll>
                                    )
                                })}
                            </Row>
                        </Coll>
                    </Row>
                </Container>
            );
        }else {return  <Container fluid={true} className={"px-lg-3 px-md-3 px-sm-1 px-xl-5 px-xxl-5 pt-3 mx-0 bg-light "}>
            <Row>
                <Coll>
                    <CarFullName brand={"Mercedes-Benz"} model={"BO7104RT"}/>
                </Coll>
            </Row>
            <Row>
                <Coll>
                    <FiveStarsMark mark={this.state.mark}></FiveStarsMark>
                </Coll>
            </Row>
            <Row className={"pt-2"}>
                <Coll xxl={4} xl={5} lg={6} md={7} sm={12} xs={12} className={" "}>
                    <CarImageCarousel imgArray={carImages}></CarImageCarousel>
                </Coll>
                <Coll xxl={8} xl={7} lg={6} md={5} sm={12} xs={12}
                      className={"pl-lg-5 pl-md-5 pl-sm-5 pl-xs-5 "}>
                    <Row className={"pt-2"}>
                        <Coll xxl={7} xl={7} lg={6} md={6} sm={5} xs={6} className={"pr-0"}>
                            <h3>from 30{this.state.valute}/day </h3>
                        </Coll>
                        <Coll className={"pl-0 pr-4"}>
                            <Button block={true} variant={"warning"} size={"lg"}>Book a car </Button>
                        </Coll>
                    </Row>
                    <Row lg={4} xxl={4} xl={4} md={4} sm={4} xs={4}
                         className={"pt-3 g-lg-2 g-xxl-2 g-md-1 g-sm-1 px-0 justify-content-center "}>
                        {costs.map((cost, index) => {
                            return (
                                <Coll><CostCart Period={cost.Time} Cost={cost.Cost}/></Coll>
                            )
                        })}
                    </Row>
                    <Row lg={4} xxl={8} xl={4} md={3} sm={4} xs={4}
                         className={"gx-lg-4 gx-xxl-5 gx-md-3 gx-sm-1 gx-xs-1 gy-3 pr-0   mb-0 mt-2 justify-content-center  d-flex px-auto"}>
                        {this.state.params.map((param, index) => {
                            return (
                                <Coll className={""}><ParametrCard SVG={param.icon} value={param.value}/></Coll>
                            )
                        })}
                    </Row>
                </Coll>
            </Row>
        </Container>}
    }
}