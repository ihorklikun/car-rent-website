import React, {useState, useEffect} from "react";
import {Modal, Button, Form} from 'react-bootstrap';
import http from '../http-common';
function ConditionReportModalWIndow(props){
    const carId = props.carid;
    const [conditionMark, setConditionMark] = useState(null);
    const [LCPConditionMark, setLCPConditionMark] = useState(null);
    const [description, setDescription] = useState(null);
    const [fuelVolume, setFuelVolume] = useState(0);
    const [carMileage, setCarMileage] = useState(0);

    var options = [0,1,2,3,4,5]
    const generateReport = ()=>{
        //console.log("I`m here" + fuelVolume);
        var jsonData = {
            "ManagerId": null,
            "FuelVolume": fuelVolume,
            "CarMileage": carMileage,
            "InteriorConditionMarkId": conditionMark,
            "LPCConditionMarkId": LCPConditionMark,
            "IsCritical": null,
            "Description": description,
            "CarId": carId
        };
        http.post("", jsonData, validateStatus => true).then((responce)=>{
            var status = responce.status;
            console.log(status);
            props.onHide();
        }).catch(e =>{
            console.log({e});
        } );
    }
    return (
        <Modal {...props}
        aria-labelledby="contained-modal-title-vcenter"
        centered>
            <Modal.Header>
                <Modal.Title>Condition report generation</Modal.Title>
            </Modal.Header>
            <Modal.Body>
                <Form>
                    <Form.Group>
                        <Form.Label>Fuel volume</Form.Label>
                        <Form.Control type = "text" value ={fuelVolume} placeholder ="123" onChange ={(e)=>{
                            const re = /^[0-9\b]+$/;
                            if(e.target.value === '' || re.test(e.target.value)){
                                setFuelVolume(e.target.value);
                            }
                        }}></Form.Control>
                        <Form.Text>Enter current fuel volume</Form.Text>
                    </Form.Group>
                    <Form.Group>
                        <Form.Label>Car mileage</Form.Label>
                        <Form.Control type = "text" placeholder="123" value ={carMileage} onChange ={(e)=>{
                            const re = /^[0-9\b]+$/;
                            if(e.target.value === '' || re.test(e.target.value)){
                                setCarMileage(e.target.value);
                            }
                        }}></Form.Control>
                        <Form.Text>Enter current car mileage</Form.Text>
                    </Form.Group>
                    <Form.Group>
                        <Form.Label>Interior condition mark</Form.Label>
                        <Form.Control as = "select" value = {conditionMark} onChange ={(e)=>{
                            setConditionMark(e.target.value);
                            }}>
                                {options.map((option)=>(
                                    <option value = {option}>{option}</option>
                                ))}
                            </Form.Control>
                        <Form.Text>Select mark for interior condition</Form.Text>
                    </Form.Group>
                    <Form.Group>
                        <Form.Label>LPC condition mark</Form.Label>
                        <Form.Control as = "select" value = {LCPConditionMark} onChange ={(e)=>{
                            setLCPConditionMark(e.target.value);
                            }}>
                                {options.map((option)=>(
                                    <option value = {option}>{option}</option>
                                ))}
                            </Form.Control>
                        <Form.Text>Select mark for LPC condition</Form.Text>
                    </Form.Group>
                    <Form.Group>
                        <Form.Label>Description</Form.Label>
                        <Form.Control as = "textarea" onChange ={(e)=>{
                            setDescription(e.target.value);
                            }}>
                            </Form.Control>
                        <Form.Text>Provide some description if you need</Form.Text>
                    </Form.Group>
                </Form>
            </Modal.Body>
            <Modal.Footer>
            <Button variant = "success" onClick = {generateReport}>Send report</Button>
            <Button variant = "warning" onClick = {props.onHide}>Cancel</Button>
            </Modal.Footer>
        </Modal>
    );
}

export default ConditionReportModalWIndow;