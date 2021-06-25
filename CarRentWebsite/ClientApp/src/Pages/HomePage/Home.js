import React, { Component } from 'react'
import { 
    Container, 
    Button,
    Col,
    Row,
} from 'react-bootstrap'

import OneItemSelector from './Components/OneItemSelector'
import RangeSelectorElement from './Components/RangeSelectorElement'
import MultiItemSelector from './Components/MultiItemSelector'
import CarCardsDeck from './Components/CarCardsDeck'
import http from '../../http-common';

export default class Home extends Component {

    constructor(props) {
        super(props);
        this.state = {
               carBrandArray: [],
                cityArray: [],
                transmitionArray: [],
                fuelArray: [],
                carsArray: [],
                sort: '',
                city: '',
                selectedMinPrice: '',
                selectedMaxPrice: '',
                brands: [],
                transmitions: [],
                fuelTypes: [],
                selectedMinSeats: '',
                selectedMaxSeats: ''
        };
    }

    componentDidMount() {
        http.get("http://localhost:25094/api/Cities").then((responce) => {
            const data = responce.data;
            this.setState({
                cityArray: data
            });
        }).catch(e => {
            console.log(e);
        });

        http.get("http://localhost:25094/api/Brands").then((responce) => {
            const data = responce.data;
            this.setState({
                carBrandArray: data
            });
        }).catch(e => {
            console.log(e);
        });

        http.get("http://localhost:25094/api/Fuels").then((responce) => {
            const data = responce.data;
            this.setState({
                fuelArray: data
            });
        }).catch(e => {
            console.log(e);
        });

        http.get("http://localhost:25094/api/Transmissions").then((responce) => {
            const data = responce.data;
            this.setState({
                transmitionArray: data
            });
        }).catch(e => {
            console.log(e);
        });


        http.get("http://localhost:25094/api/Cars").then((responce) => {
            const data = responce.data;
            //console.log(data);
            this.setState({
                carsArray: data
                
            });
            //console.log(this.setState.carList);
        }).catch(e => {
            console.log(e);
        });

    }

    handleSort = (e) =>{
        this.setState({sort: e.target.value})
    }

    handleCitySelect = (e) =>{
        this.setState({ city: e.target.value });
        console.log(e.target.value);
    }

    handlePriceSelect = (e) =>{
        if(e.target.id === 'from'){
            this.state.selectedMinPrice = e.target.value
        }
        else if(e.target.id === 'to'){
            this.state.selectedMaxPrice = e.target.value
        }

        if(this.state.selectedMinPrice > this.state.selectedMaxPrice 
            || this.state.selectedMinPrice <= 0 || this.state.selectedMaxPrice <= 0
        ){
            e.target.style.backgroundColor = "#ad2013";
        }
        else{
            e.target.style.backgroundColor = "#ffffff"
            this.setState({selectedMinPrice: this.state.selectedMinPrice})
            this.setState({selectedMaxPrice: this.state.selectedMaxPrice})
        }
    }

    handleBrandSelect = (e) =>{ 
         if (e.target.checked == true){
            this.state.brands.indexOf(e.target.value) === -1 ? this.state.brands.push(e.target.value) : console.log('brand exists')
         }
         else{
            const index = this.state.brands.indexOf(e.target.value)
            index !== -1 ? this.state.brands.splice(index, 1) : console.log('brand not exists') 
         }
         this.setState({brands: this.state.brands})
    }

    handleTransmitionSelect = (e) =>{
        if (e.target.checked == true){
            this.state.transmitions.indexOf(e.target.value) === -1 ? this.state.transmitions.push(e.target.value) : console.log('brand exists')
         }
         else{
            const index = this.state.transmitions.indexOf(e.target.value)
            index !== -1 ? this.state.transmitions.splice(index, 1) : console.log('brand not exists') 
         }
         this.setState({transmitions: this.state.transmitions})
    }

    handleFuelTypeSelect = (e) =>{
        if (e.target.checked == true){
            this.state.fuelTypes.indexOf(e.target.value) === -1 ? this.state.fuelTypes.push(e.target.value) : console.log('brand already exists')
         }
         else{
            const index = this.state.fuelTypes.indexOf(e.target.value)
            index !== -1 ? this.state.fuelTypes.splice(index, 1) : console.log('brand not exists, can not delete') 
         }
         this.setState({fuelTypes: this.state.fuelTypes})
    }

    handleSeatsSelect = (e) =>{
        if(e.target.id === 'from'){
            this.state.selectedMinSeats = e.target.value
        }
        else if(e.target.id === 'to'){
            this.state.selectedMaxSeats = e.target.value
        }

        if(+this.state.selectedMinSeats > +this.state.selectedMaxSeats ){
            if(+this.state.selectedMinSeats <= 0 || +this.state.selectedMaxSeats <= 0){
                e.target.style.backgroundColor = "#ad2013";
            }
        }
        else{
            e.target.style.backgroundColor = "#ffffff"
            this.setState({selectedMinSeats: this.state.selectedMinSeats})
            this.setState({selectedMaxSeats: this.state.selectedMaxSeats})
        }
    }

    render() {
      
        let sortedBooks = this.state.carsArray.sort((a, b) =>{
            if(this.state.sort == "Name"){
                if (a.model > b.model) {
                    return 1;
                  }
                  if (a.model < b.model) {
                    return -1;
                  }
                  return 0;
            }
            else if(this.state.sort == "High-to-low"){
                return b.price - a.price
            }
            else if(this.state.sort == "Low-to-high"){
                return a.price - b.price
            }
        })
        console.log(sortedBooks);

        if(this.state.city){
            sortedBooks = sortedBooks.filter(e => e.location.city.id == this.state.city);
        }

        if(+this.state.selectedMaxPrice >= 0 && +this.state.selectedMinPrice >= 0 &&
            this.state.selectedMaxPrice && this.state.selectedMinPrice){
            sortedBooks = sortedBooks.filter(e => ((+e.price <= +this.state.selectedMaxPrice) && (+e.price >= +this.state.selectedMinPrice)));
        }

        if(+this.state.brands.length > 0){
            sortedBooks = sortedBooks.filter(e => this.state.brands.includes(e.brand.id.toString()));
        }

        if (+this.state.transmitions.length > 0) {
            sortedBooks = sortedBooks.filter(e => this.state.transmitions.includes(e.transmission.id.toString()));
        }

        if(+this.state.fuelTypes.length > 0){
            sortedBooks = sortedBooks.filter(e => this.state.fuelTypes.includes(e.fuel.id.toString()));
        }

        if(+this.state.selectedMaxSeats >= 0 && +this.state.selectedMinSeats >= 0 &&
            this.state.selectedMaxSeats && this.state.selectedMinSeats){
            sortedBooks = sortedBooks.filter(e => ((+e.seatsCount <= +this.state.selectedMaxSeats) && (+e.seatsCount >= +this.state.selectedMinSeats)));
        }

        return (
            <>
            <Container borderStyle="solid">
                <h2 className="text-center m-4">ALL OFFERS</h2>
                <label style={{textAlign:'center', display:'block'}} className="text m-4">Be prepared to travel anywhere, because our cars already are</label>
                <select defaultValue="Name" aria-label="Default select example" onChange={this.handleSort} style={{float: 'right'}}>
                    <option value="Name"selected>Name</option>
                    <option value="High-to-low">From high to low</option>
                    <option value="Low-to-high">From low to high</option>
                </select>
                <h6>Filters:</h6>
                <Row>
                <Col lg={3}>
                {/* City selector item*/}
                <OneItemSelector
                    onChangeValue={this.handleCitySelect}
                    Title="City:"
                    postArray={this.state.cityArray}
                />

                {/* Period selector item*/}
                <RangeSelectorElement
                    Title="Period of rent:" 
                    LeftBorder="From"
                    LeftPlaceholder="01/09/2021" 
                    RightBorder="To"
                    RightPlaceholder="02/09/2021"   
                    Type="date"
                />

                {/* Price selector item*/}
                <RangeSelectorElement
                    onChangeValue={this.handlePriceSelect}
                    Title="Price:" 
                    LeftBorder="From"
                    LeftPlaceholder="$0" 
                    RightBorder="To"
                    RightPlaceholder="$1000"   
                    Type="number"
                />

                {/* Brands selector item*/}
                <MultiItemSelector
                    onChangeValue={this.handleBrandSelect} 
                    Title="Brands:" 
                    postArray={this.state.carBrandArray}
                />

                {/* Transmition selector item*/}
                <MultiItemSelector 
                    onChangeValue={this.handleTransmitionSelect} 
                    Title="Transmition:" 
                    postArray={this.state.transmitionArray}
                />
                
                 {/* Fuel selector item*/}
                 <MultiItemSelector 
                    onChangeValue={this.handleFuelTypeSelect} 
                    Title="Fuel type:" 
                    postArray={this.state.fuelArray}
                />
                 
                {/* Number of seats selector item*/}
                <RangeSelectorElement
                    onChangeValue={this.handleSeatsSelect}
                    Title="Number of seats:" 
                    LeftBorder="From"
                    LeftPlaceholder="1" 
                    RightBorder="To"
                    RightPlaceholder="20"   
                    Type="number"
                />
                
                {/* Car cards*/}
                </Col>
                <Col lg={9}>
                    <CarCardsDeck id="cars-list" postArray={sortedBooks} />
                </Col>
                </Row>
            </Container>
            </>
        )
    }
}
