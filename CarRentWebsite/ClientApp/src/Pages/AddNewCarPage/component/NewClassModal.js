import React, {Component} from "react";
import {Button, Form, FormControl, FormGroup, Modal} from "react-bootstrap";
export default class NewClassModal extends Component{
    constructor(props) {
        super(props);
        this.state={name:NaN};
        this.handleSubmit=this.handleSubmit.bind(this)
        this.handleChanges=this.handleChanges.bind(this)
    }
    handleChanges(event){
        console.log(event.target);
        const name=event.target.value;
        if ((event.target)&&(event.target.type=="text")){
            this.setState(state=>({name:name}))
        }
    }
    handleSubmit(event){
    }
    render() {
        return(
            <Modal show={this.props.show} autoFocus={true}  size={"sm"}  onHide={this.props.onHide} centered={true} >
                <Modal.Header closeButton={true}>
                    <Modal.Title>Add new Class</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <Form>
                        <FormGroup>
                            <Form.Label>
                                Class Name
                            </Form.Label>
                            <FormControl type={"text"} placeholder={"Class"} onChange={this.handleChanges}></FormControl>
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