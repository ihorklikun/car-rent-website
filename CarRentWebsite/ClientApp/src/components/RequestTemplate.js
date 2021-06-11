import React, {useState} from 'react';
import "./TemplateStyle.css"
import {AiFillCar} from "react-icons/ai"
import { Row, Button, Col } from 'react-bootstrap';
function RequestTemplate(props){
    const data = props.data;
    return (
        <Row className = "text-center templateStyle">
            <Col md>
                <h3 id = "carNameStyle">Car name</h3>
                <AiFillCar size = '100px'/>
                <h4 className = "headerText">Number</h4>
            </Col>
            <Col md className = "style2">
                <h5 className ="headerText">Car supply place</h5>{/*props.name*/}
                <p className ="dataText text-left">Place will be here</p>
                <h5 className = "headerText">Place of return of the car</h5>
                <p className="dataText text-left">place will be here</p>
            </Col>
            <Col md className = "style3">
                <h5 className = "headerText">Car works list</h5>
                <p>Options Will be Here</p>
                <Button variant= "success" className= "buttonStyle1">Process</Button>
            </Col>
        </Row>
    );
}

export default RequestTemplate;