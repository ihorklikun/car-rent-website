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
const reports=[
    {
        id:0,
        createDate: new Date("2021-06-16"),
        fuelVolume: 20,
        carMileage: 1000,
        interiorConditionMarkId:5,
        lpcConditionMarkId:4,
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "
    },
    {
        id:1,
        createDate: new Date("2021-06-16"),
        fuelVolume: 30,
        carMileage: 5000,
        interiorConditionMarkId:3,
        lpcConditionMarkId:5,
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "
    },
    {
        id:2,
        createDate: new Date("2021-06-16"),
        fuelVolume: 50,
        carMileage: 12000,
        interiorConditionMarkId:4,
        lpcConditionMarkId:4,
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "
    },
    {
        id:3,
        createDate: new Date("2021-06-16"),
        fuelVolume: 20,
        carMileage: 1000,
        interiorConditionMarkId:5,
        lpcConditionMarkId:3,
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "
    },
    {
        id:4,
        createDate: new Date("2021-06-16"),
        fuelVolume: 100,
        carMileage: 1000,
        interiorConditionMarkId:5,
        lpcConditionMarkId:2
    }
]
    const test=<Rating readOnly size={"small"}  value={0}/>
const selectOptions =
    {
        0: 1,
        1: 1,
        2: 2,
        3: 3,
        4: 4,
        5: 5
};
const rentColumns=[
    {dataField: 'id',text: "Id",sort:true,filter:textFilter()},
    {dataField: 'createDate',text: "Create Date",sort:true,filter: dateFilter(),formatter:DateColumnFormatter},
    {dataField: 'fuelVolume', text: "Fuel Volum",sort:true,filter: numberFilter()},
    {dataField: 'carMileage', text: "Car Mileage",sort:true,filter: numberFilter() },
    {dataField: 'interiorConditionMarkId', text: "Interior Condition",sort:true,filter: textFilter(),formatter:MarkColumnFormatter},
    {dataField: 'lpcConditionMarkId', text: "LPC Condition Mark",sort:true,filter: selectFilter({options:selectOptions}),formatter:MarkColumnFormatter},
]
const defaultSorted=[{
    dataField: "id",
    order:"asc"
}]
export function DateColumnFormatter(cell,row){
    return <span>{cell.toLocaleDateString()}</span>;
}
export function MarkColumnFormatter(cell,row){
    return <Rating readOnly size={"small"}  value={cell}/>
}
export function CostColumnFormatter(cell,row){
    return <span>{cell}$</span>
}
export default class ReportsTable extends Component{
    constructor(props) {
        super(props);
        this.state={reports:reports}
    }
    render() {
        const expandRow = {
            renderer: row => (
                <Card >
                    <Card.Header><h5>Description </h5></Card.Header>
                    <Card.Body>
                        <Card.Text>
                            <p > {(this.state.reports.find(rent=>rent.id==row.id).description ? this.state.reports.find(rent=>rent.id==row.id).description : "None")}</p>
                        </Card.Text>
                    </Card.Body>
                </Card>
            ),
            showExpandColumn: true
        };
        return(
            <BoostrapTable
                wrapperClasses="table-responsive"
                rowClasses="text-nowrap "
                ref={n=>this.node=n}
                keyField={"id"}
                data={reports}
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