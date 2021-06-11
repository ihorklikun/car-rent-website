import React, {useState} from 'react';
import {AiFillCar} from "react-icons/ai"
import "./TemplateStyle.css"
import Button from 'react-bootstrap/Button';
import { Row } from 'react-bootstrap';
import { Col } from 'react-bootstrap';
import { Form } from 'react-bootstrap';
import { Modal } from 'react-bootstrap';

function InProgressTemplate(params){
    const [showModal1, setShow1] = useState(false);
    return (
        <Row className = "text-center templateStyle">
            <Col md>
                <h3 id = "carNameStyle">Car name</h3>
                <AiFillCar size = '100px'/>
                <h4 className = "headerText">Number</h4>
            </Col>
            <Col md>
                <h5 className ="headerText">Car supply place</h5>
                <p className ="dataText text-left">Place will be here</p>
                <h5 className = "headerText">Place of return of the car</h5>
                <p className="dataText text-left">place will be here</p>
                <Button variant = "warning" className = "buttonStyle1">Request for parts</Button>
            </Col>
            <Col md>
                <h5 className = "headerText">Car works list</h5>
                <Form className ="text-left" id= "tasksProgress">
                    <Form.Check
                    checked = {true} readOnly
                    label = "some option"
                    />
                    <Form.Check
                    checked = {true} readOnly
                    label = "some option 2"
                    />
                </Form>
                <Button variant= "danger" className= "buttonStyle1" onClick = {()=> setShow1(true)}>Return car</Button>
                <ModalWindow
                    show ={showModal1}
                    onHide = {()=>setShow1(false)}
                />
            </Col>
        </Row>
    );
}

export default InProgressTemplate;

function ModalWindow(props){

    const [isActive, setActive] = useState(true);
    const firstOption = ()=> {
        setActive(!isActive);
    };
    return(
        <Modal {...props}
        aria-labelledby="contained-modal-title-vcenter"
        centered>
            <Modal.Header closeButton>
                <Modal.Title>Options selection</Modal.Title>
            </Modal.Header>
            <Modal.Body>
                <Col>
                    <Button variant = {isActive? "primary" : "secondary"} className = "ModalButtonStyle" onClick = {firstOption} active = {isActive}>Some option here</Button>
                    <Button variant = "secondary" className = "ModalButtonStyle" onClick = {props.onHide}>Some option here</Button>
                </Col>
                
            </Modal.Body>
            <Modal.Footer>
                <Button variant = "warning" onClick = {props.onHide}>Close</Button>
            </Modal.Footer>
        </Modal>
    );
}