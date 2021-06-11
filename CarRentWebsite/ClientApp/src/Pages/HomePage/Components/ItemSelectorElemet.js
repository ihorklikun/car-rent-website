import React, { Component } from 'react'

export default class ItemSelectorElemet extends Component {
    render() {
        return (
        <label class="form-check">
            <input type={this.props.type} class="form-check-input" value={this.props.id}  name="exampleRadio"/>
            <span class="form-check-label">
                {this.props.body}
            </span>
        </label>
        )
    }
}
