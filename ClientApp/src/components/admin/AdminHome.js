import React, { Component } from "react";
import { Link } from "react-router-dom";
import { Row, Col, Button } from "reactstrap";

export class HomeAdmin extends Component {
  render() {
    return (
      <Row className="my-5">
        <Col md={2} className="mb-2 mx-auto">
        <Link to="/admin/user-list"  className={"btn btn-outline-dark h-100 w-100"}>
            <div className={"text-center home-block"}>Users</div>
          </Link>
        </Col>
        <Col md={2} className="mb-2 mx-auto">
        <Link to="/admin/page-content"  className={"btn btn-outline-dark h-100 w-100"}>
            <div className={"text-center home-block"}>Page Content</div>
          </Link>
        </Col>
        <Col md={2} className="mb-2 mx-auto">
          <Link to="/admin/projects"  className={"btn btn-outline-dark h-100 w-100"}>
            <div className={"text-center home-block"}>Projects</div>
          </Link>
        </Col>
        <Col md={2} className="mb-2 mx-auto">
        <Link to="/admin/skills"  className={"btn btn-outline-dark h-100 w-100"}>
            <div className={"text-center home-block"}>Skills</div>
          </Link>
        </Col>
        <Col md={2} className="mb-2 mx-auto">
        <Link to="/admin/contact-messages"  className={"btn btn-outline-dark h-100 w-100"}>
            <div className={"text-center home-block"}>Contact Messages</div>
          </Link>
        </Col>
        
      </Row>
    );
  }
}

export default HomeAdmin;
