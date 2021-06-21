import React, {useState} from 'react';
import ReactDOM from 'react-dom';
import Container from "react-bootstrap/Container";
import Row from "react-bootstrap/Row";
import Button from "react-bootstrap/Button";
import Card from "react-bootstrap/Card";
import Coll from "react-bootstrap/Col"
import user from "./Resource/Images/Icons/user.png"
import FiveStarsMark, {EditableFiveStarsMark} from "./FiveStarsMark";
import {Collapse, Form, FormControl, InputGroup} from "react-bootstrap";
import Pagination from "react-bootstrap/Pagination";
import Image from "react-bootstrap/Image";
import triggerBrowserReflow from "react-bootstrap/triggerBrowserReflow";


export function Comment(props){
    return (
        <Card className={"px-1"}>
            <Card.Header className={"px-sm-1 mx-0"}>
            <Row className={"d-flex pl-2  "}   >
                <Coll className={"mr-1 px-0 ml-lg-3 ml-xl-3 ml-md-2 ml-sm-2 "} xl={"auto"} lg={"auto"} md={"auto"} sm={"auto"} xs={"auto"} >
                    <Image className={"rounded-circle px-0 mx-0 " } src={user} style={{minWidth:"3rem", maxWidth:"4rem"}}  alt={"UserIco"} roundedCircle={true}/></Coll>
                <Coll className={"mr-auto  ml-0 p-0 "}  xl={"auto"} lg={"auto"} md={"auto"} xs={"auto"} sm={"auto"} >
                    <h5>{props.userName}</h5>
                    <p>{props.CreateDate}</p>
                </Coll>
                <Coll className={"ml-auto mr-0 pr-0"}  xl={"auto"} lg={"auto"} md={"auto"} xs={"auto"} sm={"auto" }  >
                    <FiveStarsMark mark={props.Mark} starSize={"large"}></FiveStarsMark>
                </Coll>
            </Row>
            </Card.Header>
            <Card.Body>
                <Card.Title className={"text-body "}>
                    {props.Title}
                </Card.Title>
                <Card.Text>
                    {props.Text}
                </Card.Text>
            </Card.Body>
            <Card.Footer></Card.Footer>
        </Card>);
}
export class CommentForm extends React.Component{
    constructor(props) {
        super(props);
        this.state={collapsed:true,Title:"",Text:"",Mark:0,TitleError:null,CommentError:null};
        this.handleCollapseButtonClick=this.handleCollapseButtonClick.bind(this);
        this.handleChange=this.handleChange.bind(this);
        this.handleRatingChange=this.handleRatingChange.bind(this);
        this.handleSubmit=this.handleSubmit.bind(this);
    }
    handleCollapseButtonClick(){
        this.setState(state=>({
           collapsed: !this.state.collapsed
        }));
        console.log(this.state.collapsed)
    }
    handleSubmit(event){
        event.preventDefault();
        if((!this.state.Title)||(this.state.Title=="")){
            this.setState(state=>({
                TitleError: "Title must be entered"
            }));
        }
        if ((!this.state.Text)||(this.state.Text=="")){
            this.setState(state=>({
                CommentError: "Comment must be entered"
            }));
        }
        const comment={CustomerId:0,Title: this.state.Title,Text:this.state.Text,Mark: this.state.Mark,CreateDate: new Date()};
        console.log(JSON.stringify(comment));
    }
    handleRatingChange(field,value){
        console.log(field+" "+value.toString());
        this.setState({[field]:value});
    }
    handleChange(event){
        console.log(event.target.name+" "+event.target.value.toString() );
        this.setState({[event.target.name]:event.target.value});
        if((this.state.Title)&&(this.state.Title!=="")){
            this.setState(state=>({
                TitleError: null
            }));
        }
        if((this.state.Text)&&(this.state.Text!=="")){
            this.setState(state=>({
                CommentError: null
            }));
        }
    }
    render() {
        return(
            <Container fluid={true} className={""} >
             <Row fluid={true} className={" bg-light "} >
                 <Coll className={"d-grid text-center mx-auto"} xl={3} lg={4} sm={8} md={5} xs={12}>
                 <Button type={"button"} className={" align-middle align-self-center my-3 "} variant={"warning"} size={"lg"} onClick={this.handleCollapseButtonClick} >{this.state.collapsed? "Write Comment" : "Close"}</Button>
                 </Coll>
             </Row>
            <Collapse in={!this.state.collapsed}>
            <Card className={"px-0"}>
                <Form onSubmit={this.handleSubmit}>
                <Card.Header className={"px-sm-1 mx-0"}>
                    <Row className={"d-flex pl-2   "}   >
                        <Coll className={"mr-1 px-0 ml-lg-3 ml-xl-3 ml-md-2 ml-sm-2"} xl={"auto"} lg={"auto"} md={"auto"} sm={"auto"} xs={"auto"} > <Image src={user} style={{minWidth:"3rem", maxWidth:"4rem"}}  alt={"UserIco"} roundedCircle={true}/></Coll>
                        <Coll className={"mr-auto  ml-0 p-0 align-self-end "}  xl={"auto"} lg={"auto"} md={"auto"} xs={"auto"} sm={"auto"} >
                            <h5>{this.props.userName}</h5>
                            <p>{this.props.date}</p>
                        </Coll>
                        <Coll className={"ml-auto mr-0 pr-0"}  xl={"auto"} lg={"auto"} md={"auto"} xs={"auto"} sm={"auto" }  >
                            <EditableFiveStarsMark mark={5} name={"Mark"} starSize={"large"} onChange={this.handleRatingChange.bind(this)} ></EditableFiveStarsMark>
                        </Coll>
                    </Row>
                </Card.Header>
                <Card.Body>
                      <Form.Group>
                          <Form.Label>Comment Title</Form.Label>
                          <Form.Control  type={"text"} placeholder={"Comment Title"} name={"Title"}  onChange={this.handleChange} isInvalid={!!this.state.TitleError}>
                          </Form.Control>
                          <Form.Control.Feedback type={"invalid"}>
                              {this.state.TitleError}
                          </Form.Control.Feedback>
                      </Form.Group>
                        <Form.Group>
                            <Form.Label>Comment</Form.Label>
                            <Form.Control as={"textarea"} placeholder={"Comment"} rows={"3"} name={"Text"} onChange={this.handleChange} isInvalid={!!this.state.CommentError}/>
                            <Form.Control.Feedback type={"invalid"}>
                                {this.state.CommentError}
                            </Form.Control.Feedback>
                        </Form.Group>
                </Card.Body>
                <Card.Footer className={""}>
                    <Row  className={"justify-xl-content-end justify-content-lg-end justify-content-md-end justify-content-sm-center justify-content-xs-center "}>
                        <Coll xl={1} lg={2} md={2} sm={3} xs={4}  className={"d-grid ms-auto"}>
                            <Button className={""}  type={"submit"}  variant={"warning"}>Send</Button>
                        </Coll>
                        <Coll xl={1} lg={2} md={2} sm={3} xs={4} className={"d-grid mr-sm-auto mr-xs-auto mr-md-2 mr-lg-2 mr-xl-2  "}>
                            <Button className={""} type={"reset"} variant={"warning"}>Cancel</Button>
                        </Coll>
                    </Row>
                </Card.Footer>
                </Form>
            </Card>
            </Collapse>
            </Container>);
    }
}
export class Comments extends React.Component{
    constructor(props) {
        super(props);
        this.state={carId:this.props.carId};
    }
    render() {return(
        <Container fluid className={"px-lg-4 px-md-4 px-sm-3 px-xs-1 px-xl-5 px-xxl-5 pt-3 mx-0 bg-light "}>
            <Row lg={12} xs={12} sm={12} xl={12} md={12} xxl={12}>
                <h3> Comments</h3>
            </Row>
            <Row><CommentForm userName={"Melcor Eruson"} date={"10.06.2021"}/></Row>
            <ShowPaginationComments carId={this.state.carId} />
        </Container>
    )
    }
}
export class ShowPaginationComments extends React.Component {
    pages = [];
    constructor(props) {
        super(props);
        const carId=this.props.carId;
        let comments=require('./jsonData/Comments.json');
        comments=comments.filter(comment=>comment.CarId==carId);
        const defCommentsCount = 5;
        const commentsCount=comments.length
        let commentsOnPage = defCommentsCount;
        if ((this.props.commentsOnPage) && (this.props.commentsOnPage >= 0)) {
            commentsOnPage = this.props.commentsOnPage
        }
        this.handlePageChange=this.handlePageChange.bind(this)
        let pageNum = 0;
        for (var i = 0; i < comments.length; i+=commentsOnPage) {
            this.pages.push(<Pagination.Item name={pageNum} onClick={this.handlePageChange} >{pageNum+1}</Pagination.Item>)
            ++pageNum;
        }
        this.state = {commentsOnPage: commentsOnPage, commentsCount: comments.length, currentPage: 0,lastPage:(pageNum-1),comments:comments}

    }
    handlePageChange(event){
        event.preventDefault();
        const target=event.target;
        console.log(event.target.name);
        switch (target.name) {
          case  "FirstPage": {
              this.setState(state=>({
                  currentPage: 0
              }))
              break
          }
          case "PrevPage":{
              this.setState(state=>({
                  currentPage: (this.state.currentPage>0? this.state.currentPage-1:0)
              }))
              break
          }
            case "NextPage":{
                this.setState(state=>({
                    currentPage: (this.state.currentPage < this.state.lastPage ? this.state.currentPage + 1 : this.state.lastPage)
                }))
                break
            }
            case "LastPage":{
                this.setState(state=>({
                    currentPage:this.state.lastPage
                }))
                event.target.active=true;
            break
            }
            default:{
                this.setState(state=>({
                    currentPage: parseInt (target.name)

                }))
                break;
            }
        }
        console.log(this.state)
    }
    render() {
        return (
            <Container>
                <Row className={"d-grid mb-0 mt-1 pt-1"}>
                    <Coll className={"mx-auto mb-0"} xs={"auto"} sm={"auto"} md={"auto"} lg={"auto"} xl={"auto"}>
                <Pagination>
                    <Pagination.First name={"FirstPage"} onClick={this.handlePageChange}/>
                    <Pagination.Prev name={"PrevPage"} onClick={this.handlePageChange}/>
                    {this.pages}
                    <Pagination.Next name={"NextPage"} onClick={this.handlePageChange}/>
                    <Pagination.Last name={"LastPage"} onClick={this.handlePageChange}/>
                </Pagination>
                    </Coll>
                </Row>
                {this.state.comments.slice(this.state.currentPage*this.state.commentsOnPage,(this.state.currentPage+1)*this.state.commentsOnPage).map((comment, index) => {
                    return(
                        <Row className={"my-2"}> <Comment userName={comment.Customer.name+" "+comment.Customer.surname} CreateDate={comment.CreateDate}
                                                          Title={comment.Title} Text={comment.Text} Mark={comment.Mark}/></Row>)
                })}
                <Row className={"mb-0 mt-2 pt-2"}>
                    <Coll className={"mx-auto mb-0"} xs={"auto"} sm={"auto"} md={"auto"} lg={"auto"} xl={"auto"}>
                        <Pagination>
                            <Pagination.First name={"FirstPage"} onClick={this.handlePageChange}/>
                            <Pagination.Prev name={"PrevPage"} onClick={this.handlePageChange}/>
                            {this.pages}
                            <Pagination.Next name={"NextPage"} onClick={this.handlePageChange}/>
                            <Pagination.Last name={"LastPage"} onClick={this.handlePageChange}/>
                        </Pagination>
                    </Coll>
                </Row>
            </Container>)
    }
}
export  default Comments