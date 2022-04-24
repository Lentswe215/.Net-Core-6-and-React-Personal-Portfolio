import React, { Component } from 'react'
import { AdminNavMenu } from './admin-navmenu';
import {Container} from "reactstrap";
import Footer from './footer';

export class Admin extends Component {
  render() {
    return (
        <React.Fragment>
        <AdminNavMenu/>
        <Container>
        {this.props.children}
        </Container>
        <Footer/>
      </React.Fragment>
    )
  }
}

export default Admin