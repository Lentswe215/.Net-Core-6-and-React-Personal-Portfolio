import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import '../NavMenu.css';

export class AdminNavMenu extends Component {
  static displayName = AdminNavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
    return (
      <header>
        <Navbar className="navbar-dark bg-dark navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3">
          <Container>
            <NavbarBrand tag={Link} to="/admin">LenMamPortfolio Admin</NavbarBrand>
            <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
            <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar>
              <ul className="navbar-nav flex-grow">
                <NavItem>
                  <NavLink tag={Link} to="/admin/user-list">Users</NavLink>
                </NavItem>
                <NavItem>
                  <NavLink tag={Link} to="/admin/page-content">Page Content</NavLink>
                </NavItem>
                <NavItem>
                  <NavLink tag={Link}  to="/admin/projects">Projects</NavLink>
                </NavItem>
                <NavItem>
                  <NavLink tag={Link}  to="/admin/skills">Skills</NavLink>
                </NavItem>
                <NavItem>
                  <NavLink tag={Link}  to="/admin/contact-messages">Contact Messages</NavLink>
                </NavItem>
                <NavItem>
                  <NavLink tag={Link}  to="/logout">Logout</NavLink>
                </NavItem>
              </ul>
            </Collapse>
          </Container>
        </Navbar>
      </header>
    );
  }
}
