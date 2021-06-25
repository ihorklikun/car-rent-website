import React, { useState, useContext, useEffect } from 'react';
import { authenticationService } from './services/authentication.service';
import { useHistory } from "react-router-dom";
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

var managerInfo = {
    "id": "1",
    "Name": "Andrii",
    "Surname": "Harashchak",
    "Email": "manager@abc.abc",
    "Role": {
      "RoleId": "0",
      "Name": "Manager"
    }
  };
var customerInfo = {
    "id": "1",
    "Name": "Andrii",
    "Surname": "Harashchak",
    "Email": "customer@abc.abc",
    "Role": {
      "RoleId": "1",
      "Name": "Usual user"
    }
  };


export default function NaviBar() {
   
    const [person, setPerson] = useState(null);
    const [show, setShow] = useState(false);
    const [userId, setUserId] = useState(0);
    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);
    let history = useHistory();

    function handleSignIn() {
       
        authenticationService.login("user@example.com", "string")
        var personData = localStorage.getItem("currentUser");
        var data = JSON.parse(personData);
        if (personData !== null) {
            setPerson(data);
        }
        setShow(false);
    }

    function handleSignOut(){
        localStorage.clear();
        setPerson(null);
    }

    function handleProfileClick(){
        history.push({
            pathname: '/user/' + person.id,
            state: { personId: person.id}
        });
    }
    useEffect(()=>{
        var personData = localStorage.getItem("currentUser");
        var data = JSON.parse(personData);
        if (personData !== null) {
            setPerson(data);
        }
    }, []);
    const getDropdown = ()=>{
        if(person !== null){
            return( 
                            <Nav>
                                <DropdownButton id="dropdown-basic-button" title={person.name + ' ' + person.surname}>
                                {/* <Dropdown.Item variant="primary" id="dd-but-sign-in" onClick={handleShow}>Sign in</Dropdown.Item> */}
                                <Dropdown.Item variant="primary" id="dd-but-profile" onClick = {handleProfileClick}>Profile</Dropdown.Item>
                                <Dropdown.Item variant="primary" id="dd-but-sign-out" onClick={handleSignOut}>Sign out</Dropdown.Item>
                            </DropdownButton>
                        </Nav>)
                    }else {
                        return (
                            <Nav>
                            <DropdownButton id="dropdown-basic-button" title="Account">
                                <Dropdown.Item variant="primary" id="dd-but-sign-in" onClick={handleShow}>Sign in</Dropdown.Item>
                            </DropdownButton>
                        </Nav>
            )
        }
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
                        {getDropdown()}
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
