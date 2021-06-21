import React, { Component } from 'react'
import {
    Card,
    Button,
    Row
} from 'react-bootstrap'
import Coll from 'react-bootstrap/Col'
export default class CarCard extends Component {
    render() {
        return (
            <Card bg="" border="success" className="mb-4" style={{'flex-wrap':'nowrap', 'min-width':'200px', 'max-width':'300px'}}>
                <Card.Img
                    style={{padding:"20px"}}
                    variant="top"
                    src="https://static.vecteezy.com/system/resources/previews/001/193/929/original/vintage-car-png.png"
                />
                <Card.Body>
                    <Card.Title>{this.props.Title}</Card.Title>
                    <Card.Text>
                        {this.props.Description}
                    </Card.Text>
                    <Row>
                        <Coll xl={6}>
                        <Card.Text className="ml-3">
                            from {this.props.Price}$ / day
                        </Card.Text>
                        </Coll>
                        <Coll xl={4}>
                            <Button variant="primary" className="ml-2" href={'/carInfo/'+this.props.Id}>Order</Button>
                        </Coll>
                    </Row>
                </Card.Body>
            </Card>
        )
    }
}
