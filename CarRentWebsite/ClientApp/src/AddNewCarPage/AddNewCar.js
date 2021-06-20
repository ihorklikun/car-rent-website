import {Component} from "react";
import {Button, Col, Container, Form, FormControl, FormGroup, Modal, Row} from "react-bootstrap";
import React from "react";
import AddNewFuelModal from './component/NewFuelModal.js'
import NewBrandModal from "./component/NewBrandModal";
import NewCarStatus from "./component/NewCarStatus";
import NewCarTypeModal from "./component/NewCarType";
import NewClassModal from "./component/NewClassModal";
import NewEngineModal from "./component/NewEngine";
import NewTransmissionModal from "./component/NewTransmission";
import AddCarImages from "./component/AddCarImages";
const brands=[
    {
        id:0,
        name:"Honda"
    },
    {
        id:1,
        name:"Kia"
    },{
        id:2,
        name:"BMW"
    },
    {
        id:3,
        name:"Toyota"
    },{
        id:4,
        name:"Volvo"
    }
]
const fuel=[
    {
        id:0,
        name:"gasoline"
    },
    {
        id:1,
        name:"electricity"
    },
    {
        id:2,
        name:"diesel"
    }
]
const status=[
    {
        id:0,
        name:"Idle"
    },
    {
        id:1,
        name:"Rent"
    },
    {
        id:2,
        name:"Repair"
    }
]
const types=[
    {
        id:0,
        name:"Econom"
    },
    {
        id:1,
        name:"Business"
    },
    {
        id:2,
        name:"Luxury"
    }
]

const engines=[
    {
        id: 1,
        name: "Engine1",
        fuelCapacity: 6,
        power: 120,
        torque: 45,
        winCode: "ASD45ufa95"
    },
    {
        id: 2,
        name: "Engine2",
        fuelCapacity: 6,
        power: 120,
        torque: 45,
        winCode: "ASttrra95"
    },
    {
        id: 3,
        name: "Engine3",
        fuelCapacity: 6,
        power: 120,
        torque: 45,
        winCode: "1123456"
    },
    {
        id: 4,
        name: "Engine4",
        fuelCapacity: 6,
        power: 120,
        torque: 45,
        winCode: "9034hh5"
    }
]
const brands=[
    {
        id:0,
        name:"Microcar"
    },
    {
        id:1,
        name:"Subcompact car"
    },{
        id:2,
        name:"Compact car"
    },
    {
        id:3,
        name:"Mid-size"
    },{
        id:4,
        name:"Entry-level car"
    }
]
const transmissions=[
    {
        id:0,
        name:"AT"
    },
    {
        id:1,
        name:"MT"
    },{
        id:2,
        name:"AM"
    },
    {
        id:3,
        name:"CVT"
    }
]
export default class AddNewCar extends Component{
    constructor(props) {
        super(props);
        this.state=
            {
                fuelModalShow:false,
                brandModalShow:false,
                statusModalShow:false,
                typeModalShow:false,
                engineModalShow:false,
                transmissionModalShow:false,
                classModalShow:false,
                imagesModelShow:false,
                brands:brands,
                fuels:fuel,
                status:status,
                types:types,
                engines:engines,
                transmissions:transmissions,
                classes:classes,
                sBrand:NaN,sFuel:NaN,sStatus:NaN,sType:NaN,sEngine:NaN,sTransmission:NaN,sClass:NaN
            };
        this.handleShowFuel=this.handleShowFuel.bind(this);
        this.handleHideFuel=this.handleHideFuel.bind(this);
        this.handleShowClass=this.handleShowClass.bind(this);
        this.handleHideClass=this.handleHideClass.bind(this);
        this.handleShowBrand=this.handleShowBrand.bind(this);
        this.handleHideBrand=this.handleHideBrand.bind(this);
        this.handleShowStatus=this.handleShowStatus.bind(this);
        this.handleHideStatus=this.handleHideStatus.bind(this);
        this.handleShowType=this.handleShowType.bind(this);
        this.handleHideType=this.handleHideType.bind(this);
        this.handleShowEngine=this.handleShowEngine.bind(this);
        this.handleHideEngine=this.handleHideEngine.bind(this);
        this.handleShowTransmission=this.handleShowTransmission.bind(this);
        this.handleHideTransmission=this.handleHideTransmission.bind(this);
        this.handleShowImages=this.handleShowImages.bind(this);
        this.handleHideImages=this.handleHideImages.bind(this);
    }
    handleShowImages(){
        this.setState(state=>({imagesModalShow:true}));
    }
    handleHideImages(){
        this.setState(state=>({imagesModalShow:false}));
    }
    handleShowFuel(){
        this.setState(state=>({fuelModalShow:true}));
    }
    handleHideFuel(){
    this.setState(state=>({fuelModalShow:false}));
    }
    handleShowBrand(){
        this.setState(state=>({brandModalShow:true}));
    }
    handleHideBrand(){
        this.setState(state=>({brandModalShow:false}));
    }
    handleShowStatus(){
        this.setState(state=>({statusModalShow:true}));
    }
    handleHideStatus(){
        this.setState(state=>({statusModalShow:false}));
    }handleShowType(){
        this.setState(state=>({typeModalShow:true}));
    }
    handleHideType(){
        this.setState(state=>({typeModalShow:false}));
    }handleShowEngine(){
        this.setState(state=>({engineModalShow:true}));
    }
    handleHideEngine(){
        this.setState(state=>({engineModalShow:false}));
    }handleShowTransmission(){
        this.setState(state=>({transmissionModalShow:true}));
    }
    handleHideTransmission(){
        this.setState(state=>({transmissionModalShow:false}));
    }handleShowClass(){
        this.setState(state=>({classModalShow:true}));
    }
    handleHideClass(){
        this.setState(state=>({classModalShow:false}));
    }
    componentDidMount() {

    }
    handleOnChange(event){



    }
    handleOnSubmit(){



}
    render() {
        return(
            <Container>
                <Row>
                    <Col>
                        <h3> Add new Car</h3>
                    </Col>
                </Row>
                <Row>
                    <Col>
                        <Form>
                            <Row>
                                <Col>
                                    <FormGroup>
                                        <Form.Label>
                                            Brand
                                        </Form.Label>
                                        <FormControl as={"select"} defaultValue={"Choose..."} >
                                            {this.state.brands.map((brand,index)=>
                                                <option value={brand.id}>{brand.name}</option>
                                            )}
                                            <option onClick={this.handleShowBrand}>add new...</option>
                                        </FormControl>
                                        <NewBrandModal show={this.state.brandModalShow} onHide={this.handleHideBrand}></NewBrandModal>
                                    </FormGroup>
                                </Col>
                                <Col>
                                    <FormGroup>
                                        <Form.Label>
                                            Model
                                        </Form.Label>
                                        <FormControl type={"text"} placeholder={"Model"}>
                                        </FormControl>
                                    </FormGroup>
                                </Col>
                                <Col>
                                    <FormGroup >
                                        <Form.Label >
                                            Registration Number
                                        </Form.Label>
                                        <FormControl type={"text"} placeholder={"Registration"}></FormControl>
                                    </FormGroup>
                                </Col>
                            </Row>
                            <Row>
                                <Col>
                                    <FormGroup>
                                        <Form.Label>
                                            Seats Count
                                        </Form.Label>
                                        <FormControl min={0} type={"number"} placeholder={"Seats"}/>
                                    </FormGroup>
                                </Col>
                                <Col>
                                    <FormGroup>
                                        <Form.Label>
                                            ManufacturedDate
                                        </Form.Label>
                                        <FormControl type={"date"} placeholder={"Date"}/>
                                    </FormGroup>
                                </Col>
                                <Col>
                                    <FormGroup>
                                        <Form.Label>
                                            Trunk Size
                                        </Form.Label>
                                        <FormControl min={0} type={"number"} placeholder={"Chose"}></FormControl>
                                    </FormGroup>
                                </Col>
                            </Row>
                            <Row>
                                <Col>
                                    <FormGroup>
                                           <Form.Label>
                                               Fuel Type
                                           </Form.Label>
                                            <FormControl as={"select"} defaultValue={"Choose..."} >
                                            {this.state.fuels.map((fuel,index)=>
                                                <option value={fuel.id}>{fuel.name}</option>
                                            )}
                                                <option onClick={this.handleShowFuel}>add new...</option>
                                            </FormControl>
                                        <AddNewFuelModal show={this.state.fuelModalShow} onHide={this.handleHideFuel}></AddNewFuelModal>
                                    </FormGroup>
                                </Col>
                                <Col>
                                    <FormGroup>
                                        <Form.Label>
                                            Engine
                                        </Form.Label>
                                        <FormControl as={"select"} defaultValue={"Choose..."} >
                                            {this.state.engines.map((engine,index)=>
                                                <option value={engine.id}>{engine.name}</option>
                                            )}
                                            <option onClick={this.handleShowEngine}>add new...</option>
                                        </FormControl>
                                        <NewEngineModal show={this.state.engineModalShow} onHide={this.handleHideEngine}></NewEngineModal>
                                    </FormGroup>
                                </Col>
                                <Col>
                                    <FormGroup>
                                        <Form.Label>
                                            Transmission
                                        </Form.Label>
                                        <FormControl as={"select"} defaultValue={"Choose..."} >
                                            {this.state.transmissions.map((transmission,index)=>
                                                <option value={transmission.id}>{transmission.name}</option>
                                            )}
                                            <option onClick={this.handleShowTransmission}>add new...</option>
                                        </FormControl>
                                        <NewTransmissionModal show={this.state.transmissionModalShow} onHide={this.handleHideTransmission}></NewTransmissionModal>
                                    </FormGroup>
                                </Col>
                            </Row>
                            <Row>
                                <Col>
                                    <FormGroup>
                                        <Form.Label>
                                            Car Status
                                        </Form.Label>
                                        <FormControl as={"select"} defaultValue={"Choose..."} >
                                            {this.state.status.map((brand,index)=>
                                                <option value={status.id}>{status.name}</option>
                                            )}
                                            <option onClick={this.handleShowStatus}>add new...</option>
                                        </FormControl>
                                        <NewCarStatus show={this.state.statusModalShow} onHide={this.handleHideStatus}></NewCarStatus>
                                    </FormGroup>
                                </Col>
                                <Col>
                                    <FormGroup>
                                        <Form.Label>
                                            Car Type
                                        </Form.Label>
                                        <FormControl as={"select"} defaultValue={"Choose..."} >
                                            {this.state.type.map((type,index)=>
                                                <option value={type.id}>{type.name}</option>
                                            )}
                                            <option onClick={this.handleShowType}>add new...</option>
                                        </FormControl>
                                        <NewCarTypeModal show={this.state.typeModalShow} onHide={this.handleHideType}></NewCarTypeModal>
                                    </FormGroup>
                                </Col>
                                <Col>
                                    <FormGroup>
                                        <Form.Label>
                                            Car Class
                                        </Form.Label>
                                        <FormControl as={"select"} defaultValue={"Choose..."} >
                                            {this.state.classes.map((clas,index)=>
                                                <option value={clas.id}>{clas.name}</option>
                                            )}
                                            <option onClick={this.handleShowClass}>add new...</option>
                                        </FormControl>
                                        <NewClassModal show={this.state.classModalShow} onHide={this.handleHideClass}></NewClassModal>
                                    </FormGroup>
                                </Col>
                            </Row>
                            <Row className={"d-flex flex-row"} >
                                <Col className={"mr-auto d-flex justify-content-start mt-1 "} xl={"auto"} lg={"auto"} md={"auto"} sm={"auto"} xs={"auto"}>
                                    <Button variant={"secondary"}>Create Initial Report </Button>
                                    <Button variant={"secondary"} className={"mx-1"} onClick={this.handleShowImages}>Add Car Images</Button>
                                </Col>
                                <Col className={"ml-auto mr-0 d-flex justify-content-end mt-1"}  xl={"auto"} lg={"auto"} md={"auto"} sm={"auto"} xs={"auto"}  >
                                    <Button className={"mx-1"} variant={"secondary"} href={"/"}> Cancel</Button>
                                    <Button className={"mx-1"} variant={"primary"} >Submit</Button>
                                </Col>
                            </Row>
                            <AddCarImages show={this.state.imagesModalShow} onHide={this.handleHideImages}></AddCarImages>
                        </Form>
                    </Col>
                </Row>
            </Container>
        )
    }
}