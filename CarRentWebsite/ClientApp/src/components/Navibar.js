import React, {useState} from 'react';
import { 
    Container, 
    Navbar, 
    Nav, 
    Button,
    Modal,
    Form,
    Dropdown,
    DropdownButton
} from 'react-bootstrap';

//import logo from '';

export default function NaviBar(){

    const [show, setShow] = useState(false);

    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    function handleSignIn(){
        // some part of login and password check will be here

        //check user stus worker or mechanic
        document.getElementById('dd-but-sign-in').style.display = "none"
        document.getElementById('dd-but-sign-out').style.display = "block"
        document.getElementById('dd-but-profile').style.display = "block"
        document.getElementById('dropdown-basic-button').innerHTML = "User_123"
    }

    function handleSignOut(){
        document.getElementById('dd-but-sign-in').style.display = "block"
        document.getElementById('dd-but-sign-out').style.display = "none"
        document.getElementById('dd-but-profile').style.display = "none"
        document.getElementById('dropdown-basic-button').innerHTML = "Account"
    }

    return (
        <>
            <Navbar collapseOnSelect expand="md" bg="dark" variant="dark">
                <Container>
                    <Navbar.Brand href="/">
                        <img
                            
                            height="40"
                            width="auto"
                            className="d-inline-block align-top"
                            alt="Logo"
                        /> Cars&Trips
                    </Navbar.Brand>
                    <Navbar.Toggle aria-controls="responsive-navbar-nav" />
                    <Navbar.Collapse id="responsive-navbar-nav">
                        <Nav className="mr-auto">
                            <Nav.Link href="/"> Cars </Nav.Link>
                            <Nav.Link href="/about"> About us </Nav.Link>
                            <Nav.Link href="/rules"> Rules </Nav.Link>
                        </Nav>
                        <Nav>
                            <DropdownButton id="dropdown-basic-button" title="Account">
                                <Dropdown.Item variant="primary" id="dd-but-sign-in" onClick={handleShow}>Sign in</Dropdown.Item>
                                <Dropdown.Item variant="primary" id="dd-but-profile" style={{display:'none'}}>Profile</Dropdown.Item>
                                <Dropdown.Item variant="primary" id="dd-but-sign-out" style={{display:'none'}} onClick={handleSignOut}>Sign out</Dropdown.Item>
                            </DropdownButton>
                        </Nav>
                    </Navbar.Collapse>
                </Container>
            </Navbar>
            <Modal show={show} onHide={handleClose}>
                <Modal.Header closeButton>
                    <Modal.Title>Log in</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <Form>
                        <Form.Group controlId="fromBasicEmail">
                            <Form.Label>Email Address</Form.Label>
                            <Form.Control type="email" placeholder="Enter email" />
                            <Form.Text className="text-muted">We`ll never share your email with anyone else.</Form.Text>
                        </Form.Group>
                        <Form.Group controlId="fromBasicPassword">
                            <Form.Label>Password</Form.Label>
                            <Form.Control type="password" placeholder="Enter password" />
                        </Form.Group>
                        <Form.Group controlId="fromBasicCheckbox">
                            <Form.Check type="checkbox" label="Remember me" />
                        </Form.Group>
                        <Form.Group controlId="fromSignInButton">
                            <Button variant="primary" onClick={handleSignIn}>Sign in</Button>
                        </Form.Group>
                    </Form>
                </Modal.Body>
            </Modal>
        </>
        );
    }
