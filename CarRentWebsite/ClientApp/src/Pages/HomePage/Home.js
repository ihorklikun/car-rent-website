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
        carBrandArray : [
            {id: 1, body: "Ravon"},
            {id: 2, body: "Chevrolet"},
            {id: 3, body: "KIA"},
            {id: 4, body: "BMW"},
            {id: 5, body: "Mercedess-Benz"},
        ],
        cityArray : [
            {id: 1, body: "All"},
            {id: 2, body: "Lviv"},
            {id: 3, body: "Kyiv"},
            {id: 4, body: "Kharkiv"}
        ],
        transmitionArray : [
            {id: 1, body: "4 wheel drive"},
            {id: 2, body: "Front wheel drive"},
            {id: 3, body: "Rear wheel drive"}
        ],
        fuelArray : [
            {id: 1, body: "Diesel"},
            {id: 2, body: "Gasoline"},
            {id: 3, body: "Electricity"}
        ],
        carsArray : [
            {id: 1, 
                brand: "Ravon R2",
                brandId: '1',
                description: "Fine car for everyone. Can make everytjing you want to.", 
                price : 10,
                locationId: '2',
                transmitionId: '2',
                fuelTypeId: '2',
                seats: '4'
            },
            {id: 2, 
                brand: "Chevrolet Lanos",
                brandId: '2',
                description: "Fine car for everyone. Can make everytjing you want to.", 
                price : 15,
                locationId: '2',
                transmitionId: '2',
                fuelTypeId: '2',
                seats: '5'
            },
            {id: 3, 
                brand: "KIA K5",
                brandId: '3',
                description: "Fine car for everyone. Can make everytjing you want to.", 
                price : 12,
                locationId: '3',
                transmitionId: '3',
                fuelTypeId: '1',
                seats: '5'
            },
            {id: 4, 
                brand: "KIA Sportage",
                brandId: '3', 
                description: "Fine car for everyone. Can make everytjing you want to.", 
                price : 20,
                locationId: '4',
                transmitionId: '1',
                fuelTypeId: '1',
                seats: '6'
            },
            {id: 5, 
                brand: "BMW M2",
                brandId: '4',
                description: "Fine car for everyone. Can make everytjing you want to.", 
                price : 27,
                locationId: '3',
                transmitionId: '3',
                fuelTypeId: '1',
                seats: '2'
            },
            {id: 6, 
                brand: "Mercedes-Benz Profi Electro",
                brandId: '5', 
                description: "Fine car for everyone. Can make everytjing you want to.", 
                price : 22,
                locationId: '3',
                transmitionId: '1',
                fuelTypeId: '3',
                seats: '10'
            }
        ],
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
        let sortedBooks = this.state.carsArray.sort((a, b) =>{
            if(this.state.sort == "Name"){
                if (a.brand > b.brand) {
                    return 1;
                  }
                  if (a.brand < b.brand) {
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

        if(this.state.city != 1 && this.state.city){
            sortedBooks = sortedBooks.filter(e => e.locationId === this.state.city);
        }

        if(+this.state.selectedMaxPrice >= 0 && +this.state.selectedMinPrice >= 0 &&
            this.state.selectedMaxPrice && this.state.selectedMinPrice){
            sortedBooks = sortedBooks.filter(e => ((+e.price <= +this.state.selectedMaxPrice) && (+e.price >= +this.state.selectedMinPrice)));
        }

        if(+this.state.brands.length > 0){
            sortedBooks = sortedBooks.filter(e => this.state.brands.includes(e.brandId));
        }

        if(+this.state.transmitions.length > 0){
            sortedBooks = sortedBooks.filter(e => this.state.transmitions.includes(e.transmitionId));
        }

        if(+this.state.fuelTypes.length > 0){
            sortedBooks = sortedBooks.filter(e => this.state.fuelTypes.includes(e.fuelTypeId));
        }

        if(+this.state.selectedMaxSeats >= 0 && +this.state.selectedMinSeats >= 0 &&
            this.state.selectedMaxSeats && this.state.selectedMinSeats){
            sortedBooks = sortedBooks.filter(e => ((+e.seats <= +this.state.selectedMaxSeats) && (+e.seats >= +this.state.selectedMinSeats)));
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
