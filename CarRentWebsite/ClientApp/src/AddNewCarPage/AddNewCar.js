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
                brands:brands
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
                                            {this.state.brands.map((brand,index)=>
                                                <option value={brand.id}>{brand.name}</option>
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
                                            {this.state.brands.map((brand,index)=>
                                                <option value={brand.id}>{brand.name}</option>
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
                                            {this.state.brands.map((brand,index)=>
                                                <option value={brand.id}>{brand.name}</option>
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
                                            {this.state.brands.map((brand,index)=>
                                                <option value={brand.id}>{brand.name}</option>
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
                                            {this.state.brands.map((brand,index)=>
                                                <option value={brand.id}>{brand.name}</option>
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
                                            {this.state.brands.map((brand,index)=>
                                                <option value={brand.id}>{brand.name}</option>
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