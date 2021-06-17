import React, { Component } from 'react'

import ItemSelectorElement from "./ItemSelectorElemet"

export default class MultiItemSlector extends Component {
    render() {
        return (
        <article class="card-group-item">
            <header class="card-header">
                <h6 class="title">{this.props.Title}</h6>
            </header>
            <div class="filter-content">
                <div class="card-body" onChange={this.props.onChangeValue}>
                <form>
                    {
                        this.props.postArray.map((post, index)=>{
                            return(
                                <label class="form-check">
                                    <input type="checkbox" class="form-check-input" value={post.Id}  name="exampleCheck"/>
                                    <span class="form-check-label">
                                        {post.Name}
                                    </span>
                                </label>
                            )
                        })
                    }
                </form>
                </div>
            </div>
        </article>
        )
    }
}
