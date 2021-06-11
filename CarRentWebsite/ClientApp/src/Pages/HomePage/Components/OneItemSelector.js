import React, { Component } from 'react';

import{
    FormControl,
    FormLabel,
    RadioGroup,
    FormControlLabel
}
from 'react-bootstrap'

import ItemSelectorElement from "./ItemSelectorElemet"

export default class OneItemSelector extends Component{
    render(){
        return(
            <div onChange={this.props.onChangeValue}>
            {
                this.props.postArray.map((post, index)=>{
                    return(
                        <label class="form-check">
                             <input type="radio" class="form-check-input" value={post.id}  name="exampleRadio"/>
                             <span class="form-check-label">
                                 {post.body}
                             </span>
                        </label>
                    )
                })
            }
            </div>
        );
    }
}