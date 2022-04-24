import React, { Component } from "react";
import { Container, Row, Col } from "reactstrap";

export class Footer extends Component {
  render() {
    return (
      <footer className="bg-dark py-4" style={{ height: "100%" }}>
        <Container>
          <Row className="pt-3">
            <Col md={6}>
              <ul className="list-unstyled">
                <li>
                  <a href="tel:+27-81-323-0230">
                    <i className="fas fa-phone-square-alt fa-2x me-2"></i>{" "}
                    +27-81-323-0230
                  </a>
                </li>
                <li>
                  <a href="mailto:hello@ephraimmamonong.co.za">
                    <i className="fas fa-envelope fa-2x me-2"></i>{" "}
                    hello@ephraimmamonong.co.za
                  </a>
                </li>
                <li>
                  <a href="https://www.linkedin.com/in/ephraim-mamonong-295281b4?lipi=urn%3Ali%3Apage%3Ad_flagship3_profile_view_base_contact_details%3BfPViZwJGQayvabncXwOJgw%3D%3D">
                    <i className="fab fa-linkedin fa-2x me-2"></i>{" "}
                    https://www.linkedin.com/in/ephraim-mamonong
                  </a>
                </li>
              </ul>
            </Col>
            <Col md={6}></Col>
          </Row>
        </Container>
      </footer>
    );
  }
}

export default Footer;
