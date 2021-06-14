import React, {Component} from 'react';
import ReactDOM, {render} from 'react-dom';
import Container from "react-bootstrap/Container";
import 'react-bootstrap-table-next/dist/react-bootstrap-table2.min.css';
import {Table} from "react-bootstrap";
import BoostrapTable from "react-bootstrap-table-next"
import paginationFactory from 'react-bootstrap-table2-paginator';
import filterFactory, { textFilter,dateFilter,numberFilter,selectFilter } from 'react-bootstrap-table2-filter';
import Card from "react-bootstrap/Card";
import Coll from "react-bootstrap/Col";
import Rating from "@material-ui/lab/Rating";
const rents=[
    {
        id:0,
        createDate: new Date("2021-06-16"),
        carService: 'Car Service',
        isCompleted: 0,
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "
    },
    {
        id:2,
        createDate: new Date("2021-06-16"),
        carService: 'Car Service',
        isCompleted: 0,
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "
    },
    {
        id:3,
        createDate: new Date("2021-06-16"),
        carService: 'Car Service',
        isCompleted: 1,
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "
    },
    {
        id:4,
        createDate: new Date("2021-06-16"),
        carService: 'Car Service',
        isCompleted: 1,
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "
    },
    {
        id:5,
        createDate: new Date("2021-06-16"),
        carService: 'Car Service',
        isCompleted: 0,
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "
    }

]
const test=<Rating readOnly size={"small"}  value={0}/>
const selectOptions =
    {
        0: 'No',
        1: 'Yes'
    };
const rentColumns=[
    {dataField: 'id',text: "Id",sort:true,filter:textFilter()},
    {dataField: 'createDate',text: "Create Date",sort:true,filter: dateFilter(),formatter:DateColumnFormatter},
    {dataField: 'carService', text: "Car Service",sort:true,filter: textFilter()},
    {dataField: 'isCompleted', text: "Service Works Complete",sort:true, ilter: selectFilter({options:selectOptions}),formatter:cell => selectOptions[cell] },
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
export function MarkColumnFormatter(cell,row){
    return <Rating readOnly size={"small"}  value={cell}/>
}
export function CostColumnFormatter(cell,row){
    return <span>{cell}$</span>
}
export default class ServiceReportsTable extends Component{
    constructor(props) {
        super(props);
    }
    render() {
        return(
            <BoostrapTable
                wrapperClasses="table-responsive"
                rowClasses="text-nowrap "
                ref={n=>this.node=n}
                keyField={"id"}
                data={rents}
                noDataIndication={"No rents"}
                bootstrap4
                hover
                columns={rentColumns}
                defaultSorted={defaultSorted}
                pagination={paginationFactory()}
                filter={ filterFactory() }
                expandRow={ expandRow }
            />)
    }
}