import React, {Component, isValidElement} from "react";
import {Button, Col,Row, Form, FormControl, FormGroup, Modal} from "react-bootstrap";
import http from "../../../http-common";

export default class NewEngineModal extends Component{
    constructor(props) {
        super(props);
        this.state={name:NaN,winCode:NaN,power:NaN,torque:NaN,fuel:NaN,nameError:NaN,winCodeError:NaN,powerError:NaN,torqueError:NaN,fuelError:NaN};
        this.handleSubmit=this.handleSubmit.bind(this)
        this.handleChanges=this.handleChanges.bind(this)
    }
    handleChanges(event){
        console.log(event.target);
        const value=event.target.value;
        const name=event.target.name;
        if ((event.target)){
            switch (name) {
                case 'name': {
                    this.setState(state => ({name: value,nameError:NaN}))
                }
                break;
                case 'wincode': {
                    this.setState(state => ({winCode: value,winCodeError:NaN}))
                }
                break
                case 'power': {
                    this.setState(state => ({power: value, powerError:NaN}))
                }
                break;
                case 'torque': {
                    this.setState(state => ({torque: value,torqueError:NaN}))
                }
                break;
                case 'fuel': {
                    this.setState(state => ({fuel: value,fuelError:NaN}))
                }
                break

            }
        }
    }
    handleSubmit(event){
        if(!((this.state.name)&&(this.state.name!=""))){
            if(!this.state.engines.some(engine=>engine.name.toUpperCase() ==this.state.name.toUpperCase())) {
                http.post('./Brands',{
                    name:this.state.name,
                    cars:[]
                }).then(function (response) {
                    console.log(response);
                }).catch(function (error) {
                    alert(error);
                });
                console.log(this.state.brands);
                this.props.onHide();
            }else{
                this.setState(state=>({nameError:"Engine with enter name already exist"}))
            }

        }else {
            this.setState(state=>({nameError:"enter Name"}))

        }
    }
    render() {
        return(
            <Modal show={this.props.show} autoFocus={true}  size={"sm"}  onHide={this.props.onHide} centered={true} >
                <Modal.Header closeButton={true}>
                    <Modal.Title>Add new Engine</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <Form>
                        <Row>
                            <Col>
                                <FormGroup>
                                    <Form.Label>
                                        Engine Name
                                    </Form.Label>
                                    <FormControl name={'name'} type={"text"} placeholder={"Name"} isInvalid={!!this.state.nameError} onChange={this.handleChanges}></FormControl>
                                    <FormControl.Feedback type={"invalid"}>
                                        {this.state.nameError}
                                    </FormControl.Feedback>
                                </FormGroup>
                            </Col>
                            <Col>
                                <FormGroup>
                                    <Form.Label>WinCode</Form.Label>
                                    <FormControl name={'wincode'} type={"text"} isInvalid={!!this.state.winCodeError} placeholder={"WinCode"}></FormControl>
                                    <FormControl.Feedback type={"invalid"}>
                                        {this.state.winCodeError}
                                    </FormControl.Feedback>
                                </FormGroup>
                            </Col>
                        </Row>
                            <Row>
                                <Col>
                                <FormGroup>
                                    <Form.Label>Power</Form.Label>
                                    <FormControl name={'power'} type={"number"} isInvalid={!!this.state.powerError} min={0} step={10} ></FormControl>
                                    <FormControl.Feedback type={"invalid"}>
                                        {this.state.powerError}
                                    </FormControl.Feedback>
                                </FormGroup>
                                </Col>
                            </Row>
                            <Row>
                                <Col>
                                <FormGroup>
                                    <Form.Label>Torque</Form.Label>
                                    <FormControl name={'torque'} type={"number"} isInvalid={!!this.state.torqueError} min={0} step={10}></FormControl>
                                    <FormControl.Feedback type={"invalid"}>
                                        {this.state.torqueError}
                                    </FormControl.Feedback>
                                </FormGroup>
                                </Col>
                            </Row>
                            <Row>
                                <Col>
                                <FormGroup>
                                    <Form.Label>Fuel Capacity </Form.Label>
                                    <FormControl name={'fuel'} type={"number"} isInvalid={!!this.state.fuelError} min={0} step={0.1}></FormControl>
                                    <FormControl.Feedback type={"invalid"}>
                                        {this.state.fuelError}
                                    </FormControl.Feedback>
                                </FormGroup>
                                </Col>
                            </Row>
                    </Form>
                </Modal.Body>
                <Modal.Footer>
                    <Button variant={"secondary"} onClick={this.props.onHide}>Cancel</Button>
                    <Button variant={"primary"} onClick={this.handleSubmit}>Add </Button>
                </Modal.Footer>
            </Modal>
        )
    }
}
