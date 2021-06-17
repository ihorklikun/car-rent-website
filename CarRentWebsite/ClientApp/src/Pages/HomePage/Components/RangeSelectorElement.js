import React, { Component } from 'react'

export default class RangeSelectorElement extends Component {
    render() {
        return (
        <article class="card-group-item">
            <header class="card-header">
                <h6 class="title">{this.props.Title}</h6>
            </header>
            <div class="filter-content">
                <div class="card-body">
                    <div class="form-row" onChange={this.props.onChangeValue}>
                        <div class="form-group col-md-6">
                            <label>{this.props.LeftBorder}</label>
                            <input id="from" type={this.props.Type} class="form-control" placeholder={this.props.LeftPlaceholder}/>
                        </div>
                        <div class="form-group col-md-6 text-right">
                            <label>{this.props.RightBorder}</label>
                            <input id="to" type={this.props.Type} class="form-control" placeholder={this.props.RightPlaceholder}/>
                        </div>
                    </div>
                </div>
            </div>
        </article>
        )
    }
}
