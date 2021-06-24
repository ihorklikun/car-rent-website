import React from 'react';
import { Container, Row, Col, Form, Button } from 'react-bootstrap';
import {AiFillCar} from "react-icons/ai";
import './TemplateStyle.css';
function UserCarsInfoTemplate(props){
    const data = props.data;
    if(data == null)
    return (<Container></Container>);

    var begDate = new Date(data?.beginDate);
    begDate = begDate.toLocaleDateString("en-GB");
    var endDate = new Date(data?.endDate);
    endDate = endDate.toLocaleDateString("en-GB");
    return(
            <Row className = "text-center templateStyle">
            <Col md>
                <h3 id = "carNameStyle">{data.car?.brand?.name +' '+ data.car?.model ?? "car name and brand"}</h3>
                {/* <AiFillCar size = '100px'/> */}
                <img size = "100px" src = {data.car?.imageUrl ?? ""}></img>
                <h4 className = "headerText number">{data.car?.registerNumber ?? "rn"}</h4>
            </Col>
            <Col md>
                <h5 className = "headerText">Rent start date</h5>
                <p className = "dataText text-left">{begDate ?? "Rent start date"} </p>
                <h5 className = "headerText">Rent end date</h5>
                <p className = "dataText text-left">{endDate ?? "Rent rent date"} </p>
                <h5 className = "headerText " style={{backgroundColor: "#a4eb34"}}>Price</h5>
                <p className = "dataText text-left">{(data?.price + " $")?? "Price"}</p>
            </Col>
            <Col md>
                <h5 className ="headerText">Additional oprtions</h5>
                <div className = "text-left">
                        {data.additionalOptions.map((option)=>(<p className="dataText text-left" key={option.id}>{option.name + " - " +option.price +"$"}</p>))}
                </div>
            </Col>
        </Row>
    );
}
export default UserCarsInfoTemplate;