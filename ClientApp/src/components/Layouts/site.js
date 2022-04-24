import React, { Component } from "react";
import { SiteNavMenu } from "./site-navmenu";
import { Container } from "reactstrap";
export class Site extends Component {
  
  render() {
    return (
      <React.Fragment>
        <SiteNavMenu />
        <Container className={"bg-light py-3"}>{this.props.children}</Container>
      </React.Fragment>
    );
  }
}

export default Site;
