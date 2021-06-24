import React from 'react';
import { Container, Row, Col, Form, Button } from 'react-bootstrap';
import {AiFillCar} from "react-icons/ai";
import './TemplateStyle.css';
function UserCarsInfoTemplate(props){
    const data = props.data;
    return(
            <Row className = "text-center templateStyle">
            <Col md>
                <h3 id = "carNameStyle">{data?.model ?? ""}</h3>
                <AiFillCar size = '100px'/>
                <h4 className="headerText number">{data?.registerNumber ?? ""}</h4>
            </Col>
            <Col md >
                <h5 className ="headerText">Car rent place</h5>
                <p className ="dataText text-left">Place will be here</p>
                <h5 className = "headerText">Car return place</h5>
                <p className="dataText text-left">place will be here</p>
                {/* <Button variant = "warning" className = "buttonStyle">Request for parts</Button> */}
            </Col>
            <Col md>
                <h5 className = "headerText">Rent start date</h5>
                <p className = "dataText text-left">{data?.beginDate ?? "Rent start date"} </p>
                <h5 className = "headerText">Rent end date</h5>
                <p className = "dataText text-left">{data?.endDate ?? "Rent rent date"} </p>
                <h5 className = "headerText">Price</h5>
                <p className = "dataText text-left">{data?.price?? "Price"}</p>
            </Col>
        </Row>
    );
}
export default UserCarsInfoTemplate;