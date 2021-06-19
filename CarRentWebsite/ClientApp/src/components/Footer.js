import React from 'react'
import { Container } from 'react-bootstrap'

const Footer = () =>(
    <Container fluid style={{backgroundColor: '#212529', color:'#fff'}}>
        <Row>
            <Col lg={2}>
                <center>
                    <a href="/">
                        <img
                            src={logo}
                            height="60%"
                            width="70%"
                            className="d-inline-block align-top"
                            alt="Logo"
                        />
                    </a>
                    <label>Cars & Trips</label>
                    <label>All rights reserved © 2021</label>
                </center>
            </Col>
            <Col lg={2}>
                <div style={{margin: "20px 10px"}}>
                    <label>Navigation:</label>
                    <div style={{margin: "0px 20px"}}>
                        <a style={{color:"grey"}}>Cars</a>
                        <br/>
                        <a style={{color:"grey"}}>About us</a>
                        <br/>
                        <a style={{color:"grey"}}>Rules</a>
                    </div>
                </div>
            </Col>
            <Col lg={4}>
                <div style={{margin: "15px 10px"}}>
                    <label>Social media:</label>
                    <div>
                        <div style={{margin: "10px 0px"}}>
                            <a href="/">
                                <img
                                    src={logoYoutube}
                                    height="6%"
                                    width="6%"
                                    className="d-inline-block align-top"
                                    alt="Logo"
                                />
                            </a>
                            <a style={{color:"grey",margin: "0px 10px"}}>YouTube: Cars&Trips.ua</a>
                            <br/>
                        </div>
                        
                        <div style={{margin: "10px 0px"}}>
                            <a href="/">
                                <img
                                    src={logoInsta}
                                    height="6%"
                                    width="6%"
                                    className="d-inline-block align-top"
                                    alt="Logo"
                                />
                            </a>
                            <a style={{color:"grey",margin: "0px 10px"}}>Instagram: @CarsTrips.ua</a>
                            <br/>
                        </div>
                        
                        <div style={{margin: "10px 0px"}}>
                            <a href="/">
                                <img
                                    src={logoFacebook}
                                    height="6%"
                                    width="6%"
                                    className="d-inline-block align-top"
                                    alt="Logo"
                                />
                            </a>
                            <a style={{color:"grey",margin: "0px 10px"}}>Facebook: ___________</a>
                            <br style={{margin: "10px"}}/>
                        </div>
                        
                        <div style={{margin: "10px 0px"}}>
                            <a href="/">
                                <img
                                    src={logoTelegram}
                                    height="6%"
                                    width="6%"
                                    className="d-inline-block align-top"
                                    alt="Logo"
                                />
                            </a>
                            <a style={{color:"grey",margin: "0px 10px"}}>Telegram: ___________</a>
                            <br style={{margin: "10px"}}/>
                        </div>
                    </div>
                </div>
            </Col>

            <Col lg={4}>
                <div style={{float:"left",margin: "12px 10px"}} >
                    <label>Contact us: </label>
                    <br/>
                    <a href="tel:0800600000" style={{color:"grey", fontSize:"20px"}}>0 800 60 0000</a>
                </div>
            </Col>
        </Row>
    </Container>
)
export default Footer;