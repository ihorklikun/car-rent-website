import React, {Component} from 'react';
import ReactDOM from 'react-dom';
import Container from "react-bootstrap/Container";
import 'react-bootstrap-table-next/dist/react-bootstrap-table2.min.css';
import {Table} from "react-bootstrap";
import BoostrapTable from "react-bootstrap-table-next"
import paginationFactory from 'react-bootstrap-table2-paginator';
import filterFactory, { textFilter,dateFilter,numberFilter } from 'react-bootstrap-table2-filter';
import Card from "react-bootstrap/Card";
import Coll from "react-bootstrap/Col";
import http from "../../../http-common";
const rents=[
    {
    id:0,
    customer: "Taras Dyhdalovych",
    manager: "Taras Dyhdalovych",
    beginDate: new Date("2021-06-10"),
    endDate: new Date("2021-06-16"),
    price: 100, 
    rentStatus: {name:"Payed"},
    description:'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.'
    },
    {
        id:1,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:200,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:3,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:4,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:5,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:6,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:7,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:8,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:9,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:10,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:11,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:12,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"},
        description:'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.'
    },
    {
        id:13,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:14,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:15,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:16,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    },
    {
        id:17,
        customer: "Taras Dyhdalovych",
        manager: "Taras Dyhdalovych",
        beginDate: new Date("2021-06-10"),
        endDate: new Date("2021-06-16"),
        price: 100,
        rentStatus: {name:"Payed"}
    }
]
const rentColumns=[
    {dataField: 'id',text: "Id",sort:true,filter:textFilter()},
    {dataField: 'customer',text: "Customer",sort:true,filter: textFilter()},
    {dataField: 'manager', text: "Manager",sort:true,filter: textFilter()},
    {dataField: 'beginDate', text: "Begin Date",sort:true,filter: dateFilter(),formatter:DateColumnFormatter },
    {dataField: 'endDate', text: "End Date",sort:true,filter: dateFilter(),formatter:DateColumnFormatter},
    {dataField: 'price', text: "Price",sort:true,formatter:CostColumnFormatter,filter: textFilter()},
    {dataField: 'rentStatus.name', text: "Status",sort:true,filter: textFilter()}
]
const defaultSorted=[{
    dataField: "id",
    order:"asc"
}]
const expandRow = {
    renderer: row => (
        <Card >
         <Card.Header><h5>Description </h5></Card.Header>
         <Card.Body>
             <Card.Text>
                 <p > {(rents.find(rent=>rent.id==row.id).description ? rents.find(rent=>rent.id==row.id).description : "None")}</p>
             </Card.Text>
         </Card.Body>
        </Card>
    ),
    showExpandColumn: true
};
export function DateColumnFormatter(cell,row){
    return <span>{cell.toLocaleDateString()}</span>;
}
export function CostColumnFormatter(cell,row){
    return <span>{cell}$</span>
}
export default class RentTable extends Component{
    constructor(props) {
        super(props);
        this.state={rents:rents,carId:this.props.carId}
    }
    componentDidMount() {
        console.log("test log");
        if(this.state.carId) {
            http.get("./Rents/" + this.state.carId).then((responce) => {
                const data = responce.data;
                console.log("test1234")
                this.setState(state=>({
                    rents:responce.data.filter(rent=>rent.car.id==this.state.carId)
                }))
            }).catch(error => {
                this.setState(state => ({car: null}))
                console.log(error);
                console.log("test")
            })
        };
    }
    render() {
        return(
            <BoostrapTable
            wrapperClasses="table-responsive"
            rowClasses="text-nowrap "
            ref={n=>this.node=n}
            keyField={"id"}
            data={this.state.rents}
            noDataIndication={"No rents"}
            bootstrap4
            hover
            columns={rentColumns}
            defaultSorted={defaultSorted}
            pagination={paginationFactory()}
            filter={ filterFactory() }
            />)
    }
}