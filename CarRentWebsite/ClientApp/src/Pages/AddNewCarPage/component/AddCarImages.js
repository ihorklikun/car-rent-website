import React, {Component} from "react";
import {Button, Form, FormControl, FormGroup, ListGroup, Modal} from "react-bootstrap";
export default class AddCarImages extends Component{
    constructor(props) {
        super(props);
        this.state={imagesList:[],imagesError:NaN};
        this.handleSubmit=this.handleSubmit.bind(this)
        this.handleChanges=this.handleChanges.bind(this)
    }
    handleChanges(event){
        console.log(event.target);
        const name=event.target.value;
        if (event.target){
            this.setState(state=>{
                const imagesList=state.imagesList.push(name);
                return imagesList;
            })
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
                    <Modal.Title>Add car Images</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <Form>
                        <FormGroup>
                            <FormControl type={"file"} placeholder={"Brand"} onChange={this.handleChanges} isInvalid={!!this.state.nameError} ></FormControl>
                            <FormControl.Feedback>
                                {this.state.nameError}
                            </FormControl.Feedback>
                        </FormGroup>
                        <ListGroup>
                            {this.state.imagesList.map((image,index)=>
                                <ListGroup.Item>{image}</ListGroup.Item>
                            )}
                        </ListGroup>
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
