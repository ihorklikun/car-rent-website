import React, { Component } from 'react'

import {  
    CardDeck,
    Col,
    Row
} from 'react-bootstrap'

import CarCard from './CarCard'

export default class CarCardsDeck extends Component {
    render() {
        return (
            <CardDeck>
                    {
                        this.props.postArray.map((post, index)=>{
                                return(
                                    <CarCard
                                        Title={post.brand}
                                        Description={post.description}
                                        Price={post.price}
                                    />
                                )
                        })
                    }
            </CardDeck>
        )
    }
}
