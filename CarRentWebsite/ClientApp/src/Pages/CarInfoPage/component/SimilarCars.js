import React from "react";
import Container from "react-bootstrap/Container";
import Row from "react-bootstrap/Row";
import Coll from "react-bootstrap/Col";
import CarCard from "./CarCard";
import http from '../../../http-common'

const carsArray = [
    {id: 1,
        brand: "Ravon R2",
        brandId: '1',
        description: "Fine car for everyone. Can make everytjing you want to.",
        price : 10,
        locationId: '2',
        transmitionId: '2',
        fuelTypeId: '2',
        seats: '4'
    },
    {id: 2,
        brand: "Chevrolet Lanos",
        brandId: '2',
        description: "Fine car for everyone. Can make everytjing you want to.",
        price : 15,
        locationId: '2',
        transmitionId: '2',
        fuelTypeId: '2',
        seats: '5'
    },
    {id: 3,
        brand: "KIA K5",
        brandId: '3',
        description: "Fine car for everyone. Can make everytjing you want to.",
        price : 12,
        locationId: '3',
        transmitionId: '3',
        fuelTypeId: '1',
        seats: '5'
    },
    {id: 4,
        brand: "KIA Sportage",
        brandId: '3',
        description: "Fine car for everyone. Can make everytjing you want to.",
        price : 20,
        locationId: '4',
        transmitionId: '1',
        fuelTypeId: '1',
        seats: '6'
    },
    {id: 5,
        brand: "BMW M2",
        brandId: '4',
        description: "Fine car for everyone. Can make everytjing you want to.",
        price : 27,
        locationId: '3',
        transmitionId: '3',
        fuelTypeId: '1',
        seats: '2'
    },
    {id: 6,
        brand: "Mercedes-Benz Profi Electro",
        brandId: '5',
        description: "Fine car for everyone. Can make everytjing you want to.",
        price : 22,
        locationId: '3',
        transmitionId: '1',
        fuelTypeId: '3',
        seats: '10'
    }];
export default  class SimilarCars extends React.Component{
    constructor(props) {
        super(props);
        let cars=require('./jsonData/Car.json');
        this.state={similarCars:carsArray,carId:this.props.carId,car:null };
    }
    componentDidMount() {
        if(this.state.carId) {
            http.get("./Cars/").then((responce)=> {
                const data = responce.data;
                this.setState(state=>({
                    car:data.find(car=>car.id==this.state.carId)
                }))
                console.log(data.find(car=>car.id==this.state.carId))
                this.setState(state=>({
                    similarCars:data
                }));
            }).catch(error=>{
                this.setState(state=>({car:null}))
                console.log(error);
            });
        }
    }

    render(){
        if(this.state.similarCars) {
            return (
                <Container fluid className={"px-lg-3 px-md-3 px-sm-2 px-xl-5 px-xxl-5 pt-3 mx-0 bg-light  "}>
                    <Row lg={12} xs={12} sm={12} xl={12} md={12} xxl={12}>
                        <h3> Similar Cars</h3>
                    </Row>
                    <Row
                        className={"d-flex flex-row flex-nowrap overflow-auto gx-lg-3 gx-xl-0  gx-xxl-3 gx-md-3 gx-sm-1 "}>
                        {this.state.similarCars.map((carCard, index) => {
                            return (
                                <Coll xxl={2} xl={3} lg={4} md={4} sm={5} xs={6} className={"mx-2 px-0"}>
                                    <CarCard Id={carCard.id} Title={carCard.brand.name}
                                             Description={carCard.description} Price={"20"}/>
                                </Coll>
                            )
                        })}
                    </Row>
                </Container>);
        }else{
            return <Container></Container>
        }
    }
}
