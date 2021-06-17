import Alert from "react-bootstrap/Alert";
import Container from "react-bootstrap/Container";
import Rating from "@material-ui/lab/Rating";
import React, {Component} from "react";
import {render} from "react-dom";

export function FiveStarsMark(props){
    const mark=parseInt( props.mark);
    let starSize="large"
    if(props.starSize!=NaN){
        starSize=props.starSize;
    }
    if(isNaN(mark)) {
        return <Alert variant={"danger"}>Error cant parse mark</Alert>
    }else {
        return  (
            <Container   className={"my-0 py-1 d-inline-flex flex-row justify-content-start "}>
                <Rating readOnly precision={0.5} size={"large"}  value={props.mark}/>
                <span className={"ml-2 py-0 pb-0 mb-0 h5 align-middle pt-1 "}>{props.mark}</span>
            </Container>
        );
    }
}
export class EditableFiveStarsMark extends Component
{
    constructor(props) {
        super(props);
        this.state={mark:"0"}
        this.onRatingChange=this.onRatingChange.bind(this);
    }
    onRatingChange(event){
        const fieldValue = event.target.value;
        this.props.onChange(this.props.name, fieldValue);
        this.setState({mark:event.target.value});
        console.log(this.state.mark)
    }
    render()
    {
        return (
            <Container className={" py-1 d-inline-flex flex-row justify-content-start "}>
                <Rating precision={1} name={"Mark"} size={"large"} defaultValue={0} onChange={this.onRatingChange} />
                <span className={"ml-2 py-0 pb-0 mb-0 h5 align-middle pt-1 "}>{this.state.mark}</span>
            </Container>
        );
    }
}
export default FiveStarsMark;