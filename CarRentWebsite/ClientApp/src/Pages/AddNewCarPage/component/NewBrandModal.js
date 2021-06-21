import React, {Component} from "react";
import {Button, Form, FormControl, FormGroup, Modal} from "react-bootstrap";

export default class NewBrandModal extends Component{
    constructor(props) {
        super(props);
        this.state={name:NaN,nameError:true};
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

        }else {
            this.setState(state=>({nameError:"enter Name"}))
        }

    }
    render() {
        return(
            <Modal show={this.props.show} autoFocus={true}  size={"sm"}  onHide={this.props.onHide} centered={true} >
                <Modal.Header closeButton={true}>
                    <Modal.Title>Add new Brand</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <Form>
                        <FormGroup>
                            <Form.Label>
                                Brand Name
                            </Form.Label>
                            <FormControl type={"text"} placeholder={"Brand"} onChange={this.handleChanges} isInvalid={!!this.state.nameError} ></FormControl>
                            <FormControl.Feedback>
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
