import React, {useState} from 'react';
import ReactDOM from 'react-dom';
import Container from "react-bootstrap/Container";
import gpsMeter from "./Resource/Images/AdditionalOptionsIcons/gps.png"
import babyChair from "./Resource/Images/AdditionalOptionsIcons/baby-chair.png"
import trailer from  "./Resource/Images/AdditionalOptionsIcons/trailer.png"
import Row from "react-bootstrap/Row"
import Card from "react-bootstrap/Card";
import Coll from "react-bootstrap/Col";
import CardDeck from "react-bootstrap/CardDeck";
const addOptions=[
    {
        Image:gpsMeter,
        Name:"Kid`s chair",
        Cost:"10",
        Valuta:'$'
    },
    {
        Image:trailer,
        Name:"Gps meter",
        Cost:"100",
        Valuta:'$'
    },
    {
        Image:babyChair,
        Name:"Gps meter",
        Cost:"20",
        Valuta:'$'
    },
    {
        Image:gpsMeter,
        Name:"Gps meter",
        Cost:"10",
        Valuta:'$'
    },
    {
        Image:gpsMeter,
        Name:"Gps meter",
        Cost:"10",
        Valuta:'$'
    },{
        Image:gpsMeter,
        Name:"Gps meter",
        Cost:"10",
        Valuta:'$'
    },
    {
        Image:gpsMeter,
        Name:"Gps meter",
        Cost:"10",
        Valuta:'$'
    },
    {
        Image:gpsMeter,
        Name:"Gps meter",
        Cost:"10",
        Valuta:'$'
    },
    {
        Image:gpsMeter,
        Name:"Gps meter",
        Cost:"10",
        Valuta:'$'
    },
    {
        Image:trailer,
        Name:"Gps meter",
        Cost:"100",
        Valuta:'$'
    },
    {
        Image:babyChair,
        Name:"Gps meter",
        Cost:"20",
        Valuta:'$'
    },
    {
        Image:gpsMeter,
        Name:"Gps meter",
        Cost:"10",
        Valuta:'$'
    },
    {
        Image:gpsMeter,
        Name:"Gps meter",
        Cost:"10",
        Valuta:'$'
    },{
        Image:gpsMeter,
        Name:"Gps meter",
        Cost:"10",
        Valuta:'$'
    },
    {
        Image:gpsMeter,
        Name:"Gps meter",
        Cost:"10",
        Valuta:'$'
    },
    {
        Image:gpsMeter,
        Name:"Gps meter",
        Cost:"10",
        Valuta:'$'
    },
    {
        Image:gpsMeter,
        Name:"Gps meter",
        Cost:"10",
        Valuta:'$'
    }
]
function AdditionalOptionCard(props){
    let valuta='$';
    if (props.Valuta!=NaN){
        valuta=props.Valuta;
    }
    return(
    <Card bg={"light"} border={"light"} className={"justify-content-center px-0 mx-0"} body={true}  style={{maxWidth: "14rem ", minWidth:"6rem"}}   >
        <Card.Img variant={"top"} className={"px-0 mx-0"} src={props.Image}/>
        <Card.Header  className={"text-center px-0 mx-0 bg-light "}>
            <p className={"text-center  d-inline-block mx-0 px-0 h6 "}>{props.optionName}</p>
        </Card.Header>
        <Card.Body className={"justify-content-center px-0 py-0"} >
        <h5 className={"text-center"}>{props.Cost}{props.Valuta}</h5>
       </Card.Body>
    </Card>
    );
}
class AdditionalOptions extends React.Component{
    constructor(props) {
        super(props);
    }
    render(){
        return(
            <Container fluid  className={"px-lg-3 px-md-3 px-sm-2 px-xl-5 px-xxl-5 pt-3 mx-0 bg-light  "}>
            <Row lg={12} xs={12} sm={12} xl={12} md={12} xxl={12}>
                <h3> Additional Options</h3>
            </Row>
            <Row  className={"d-flex flex-row flex-nowrap overflow-auto gx-lg-3 gx-xl-0  gx-xxl-3 gx-md-3 gx-sm-1 "}>
                {addOptions.map((anObjectMapped,index)=>{return(
                   <Coll xxl={1} xl={1} lg={2} md={2} sm={3} xs={3} className={"mx-0 px-0"} >
                       <AdditionalOptionCard Valuta={anObjectMapped.Valuta} Image={anObjectMapped.Image} Cost={anObjectMapped.Cost} optionName={anObjectMapped.Name}  />
                   </Coll>
                )})}
            </Row>
            </Container>);
    }
}
export default AdditionalOptions;