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

export default class Home extends Component {
    state = {
        carBrandArray : [],
        cityArray : [],
        transmitionArray : [],
        fuelArray : [],
        carsArray: [],
        sort:'',
        city:'',
        selectedMinPrice:'',
        selectedMaxPrice:'',
        brands: [],
        transmitions: [],
        fuelTypes: [],
        selectedMinSeats:'',
        selectedMaxSeats:''
    };

    handleSort = (e) =>{
        this.setState({sort: e.target.value})
    }

    handleCitySelect = (e) =>{
        this.setState({city: e.target.value})
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
        const carList = require('./jsonData/Car.json');
        this.state.carsArray = carList

        const fuelList = require('./jsonData/Fuel.json');
        this.state.fuelArray = fuelList

        const transmitionList = require('./jsonData/Tansmition.json');
        this.state.transmitionArray = transmitionList

        const brandList = require('./jsonData/Brand.json');
        this.state.carBrandArray = brandList

        const cityList = require('./jsonData/Location.json');
        this.state.cityArray = cityList

        let sortedBooks = this.state.carsArray.sort((a, b) =>{
            if(this.state.sort == "Name"){
                if (a.Model > b.Model) {
                    return 1;
                  }
                  if (a.Model < b.Model) {
                    return -1;
                  }
                  return 0;
            }
            else if(this.state.sort == "High-to-low"){
                return b.Price - a.Price
            }
            else if(this.state.sort == "Low-to-high"){
                return a.Price - b.Price
            }
        })

        if(this.state.city != 1 && this.state.city){
            sortedBooks = sortedBooks.filter(e => e.LocationId === this.state.city);
        }

        if(+this.state.selectedMaxPrice >= 0 && +this.state.selectedMinPrice >= 0 &&
            this.state.selectedMaxPrice && this.state.selectedMinPrice){
            sortedBooks = sortedBooks.filter(e => ((+e.Price <= +this.state.selectedMaxPrice) && (+e.Price >= +this.state.selectedMinPrice)));
        }

        if(+this.state.brands.length > 0){
            sortedBooks = sortedBooks.filter(e => this.state.brands.includes(e.BrandId));
        }

        if(+this.state.transmitions.length > 0){
            sortedBooks = sortedBooks.filter(e => this.state.transmitions.includes(e.TransmitionId));
        }

        if(+this.state.fuelTypes.length > 0){
            sortedBooks = sortedBooks.filter(e => this.state.fuelTypes.includes(e.FuelId));
        }

        if(+this.state.selectedMaxSeats >= 0 && +this.state.selectedMinSeats >= 0 &&
            this.state.selectedMaxSeats && this.state.selectedMinSeats){
            sortedBooks = sortedBooks.filter(e => ((+e.SeatsCount <= +this.state.selectedMaxSeats) && (+e.SeatsCount >= +this.state.selectedMinSeats)));
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
