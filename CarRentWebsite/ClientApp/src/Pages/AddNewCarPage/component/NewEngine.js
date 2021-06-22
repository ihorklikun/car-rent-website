import React, {Component, isValidElement} from "react";
import {Button, Col,Row, Form, FormControl, FormGroup, Modal} from "react-bootstrap";

export default class NewEngineModal extends Component{
    constructor(props) {
        super(props);
        this.state={name:NaN,winCode:NaN,power:NaN,torque:NaN,fuel:NaN};
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
                    this.setState(state => ({name: value}))
                }
                break;
                case 'wincode': {
                    this.setState(state => ({winCode: value}))
                }
                break
                case 'power': {
                    this.setState(state => ({power: value}))
                }
                break;
                case 'torque': {
                    this.setState(state => ({torque: value}))
                }
                break;
                case 'fuel': {
                    this.setState(state => ({fuel: value}))
                }
                break

            }
        }
    }
    handleSubmit(event){
        console.log(this.state);
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
                                    <FormControl name={'name'} type={"text"} placeholder={"Name"} onChange={this.handleChanges}></FormControl>
                                </FormGroup>
                            </Col>
                            <Col>
                                <FormGroup>
                                    <Form.Label>WinCode</Form.Label>
                                    <FormControl name={'wincode'} type={"text"} placeholder={"WinCode"}></FormControl>
                                </FormGroup>
                            </Col>
                        </Row>
                            <Row>
                                <Col>
                                <FormGroup>
                                    <Form.Label>Power</Form.Label>
                                    <FormControl name={'power'} type={"number"} min={0} step={10} ></FormControl>
                                </FormGroup>
                                </Col>
                            </Row>
                            <Row>
                                <Col>
                                <FormGroup>
                                    <Form.Label>Torque</Form.Label>
                                    <FormControl name={'torque'} type={"number"} min={0} step={10}></FormControl>
                                </FormGroup>
                                </Col>
                            </Row>
                            <Row>
                                <Col>
                                <FormGroup>
                                    <Form.Label>Fuel Capacity </Form.Label>
                                    <FormControl name={'fuel'} type={"number"} min={0} step={0.1}></FormControl>
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
