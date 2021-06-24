import React, {Component} from "react";
import {Button, Form, FormControl, FormGroup, Modal} from "react-bootstrap";
import http from "../../../http-common";
export default class NewCarStatus extends Component{
    constructor(props) {
        super(props);
        this.state={name:NaN,nameError:NaN};
        this.handleSubmit=this.handleSubmit.bind(this)
        this.handleChanges=this.handleChanges.bind(this)
    }
    handleChanges(event){
        console.log(event.target);
        const name=event.target.value;
        if ((event.target)&&(event.target.type=="text")){
            this.setState(state=>({name:name,nameError:NaN}))
        }
    }
    handleSubmit(event){
        if((this.state.name)&&(this.state.name!="")){
            if(!this.state.status.some(status=>status.name.toUpperCase() ==this.state.name.toUpperCase())) {
                http.post('./CarStatus',{
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
                this.setState(state=>({nameError:"Car Status with enter name already exist"}))
            }

        }else {
            this.setState(state=>({nameError:"enter Name"}))

        }
    }
    render() {
        return(
            <Modal show={this.props.show} autoFocus={true}  size={"sm"}  onHide={this.props.onHide} centered={true} >
                <Modal.Header closeButton={true}>
                    <Modal.Title>Add new Status</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <Form>
                        <FormGroup>
                            <Form.Label>
                                Status Name
                            </Form.Label>
                            <FormControl type={"text"} placeholder={"Status"} onChange={this.handleChanges} isInvalid={!!this.state.nameError}></FormControl>
                            <FormControl.Feedback type={"invalid"}>
                                {this.state.nameError}
                            </FormControl.Feedback>
                        </FormGroup>
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
