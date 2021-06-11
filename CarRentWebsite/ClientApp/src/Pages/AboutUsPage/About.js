import React, { Component } from 'react'
import { Container, Tab, Nav, Row, Col} from 'react-bootstrap'

export default class About extends Component {
    render() {
        return (
            <Container>
                <Tab.Container id="ledt-tabs-example" defaultActiveKey="first" >
                    <Row>
                        <Col sm={3}>
                            <Nav variant="pills" className="flex-column mt-2" >
                                <Nav.Item>
                                    <Nav.Link eventKey="first" >What is "Cars&Tips"?</Nav.Link>
                                </Nav.Item>
                                <Nav.Item>
                                    <Nav.Link eventKey="second" >Our team</Nav.Link>
                                </Nav.Item>
                                <Nav.Item>
                                    <Nav.Link eventKey="third" >Used instruments</Nav.Link>
                                </Nav.Item>
                                <Nav.Item>
                                    <Nav.Link eventKey="fourth" >Results</Nav.Link>
                                </Nav.Item>
                            </Nav>
                        </Col>
                        <Col sm={9}>
                            <Tab.Content className="mt-3">
                                <Tab.Pane eventKey="first">
                                    <img width="700" height="auto" src="https://pngimg.com/uploads/mercedes/mercedes_PNG80135.png"></img>
                                    <p>dadadadadadada</p>
                                </Tab.Pane>
                                <Tab.Pane eventKey="second">
                                    <img width="700" height="auto" src="https://pngimg.com/uploads/mercedes/mercedes_PNG80135.png"></img>
                                    <p>dadadadadadada</p>
                                </Tab.Pane>
                                <Tab.Pane eventKey="third">
                                    <img width="700" height="auto" src="https://pngimg.com/uploads/mercedes/mercedes_PNG80135.png"></img>
                                    <p>dadadadadadada</p>
                                </Tab.Pane>
                                <Tab.Pane eventKey="fourth">
                                    <img width="700" height="auto" src="https://pngimg.com/uploads/mercedes/mercedes_PNG80135.png"></img>
                                    <p>dadadadadadada</p>
                                </Tab.Pane>
                            </Tab.Content>
                        </Col>
                    </Row>
                </Tab.Container>
            </Container>
        )
    }
}
