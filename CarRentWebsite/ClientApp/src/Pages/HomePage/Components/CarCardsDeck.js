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
                        this.props.postArray.map((post, index) =>{
                                return(
                                    <CarCard
                                        Id={post.id}
                                        Title={post.model}
                                        Description={post.description}
                                        Price={post.price}
                                        ImageUrl={post.imageUrl}
                                        
                                    />
                                )
                        })
                    }
            </CardDeck>
        )
    }
}
