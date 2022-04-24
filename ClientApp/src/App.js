import React, { Component } from "react";
import { BrowserRouter as Router, Route } from "react-router-dom";
import { Layout } from "./components/Layout";
import { Home } from "./components/Home";
import { HomeAdmin } from "./components/admin/AdminHome";
import { UserListAdmin } from "./components/admin/UserList";
import {EditUserAdmin } from "./components/admin/EditUser";
import { ProjectsAdmin } from "./components/admin/Projects";
import { SkillsAdmin } from "./components/admin/Skills";
import { PageContentAdmin } from "./components/admin/PageContent";
import { ContactMessagesAdmin} from "./components/admin/ContactMessages";

//Layouts
import { Admin } from "./components/Layouts/admin";
import { Site } from "./components/Layouts/site";

import "./css/Style.min.css";
import "./Plugins/fontawesome5/all.min.css";

const AppRoute = ({ component: Component, layout: Layout, ...rest }) => {
return( <Route
    {...rest}
    render={(props) => (
      <Layout>
        <Component {...props}></Component>
      </Layout>
    )}
  ></Route>)
};

function App() {
  return (
    <Router>
      <AppRoute path="/" exact layout={Site} component={Home} />
      <AppRoute path="/admin" exact layout={Admin} component={HomeAdmin}/>
      <AppRoute path="/admin/user-list" layout={Admin} component={UserListAdmin}/>
      <AppRoute path="/admin/user-edit" layout={Admin} component={EditUserAdmin}/>
      <AppRoute path="/admin/projects" layout={Admin} component={ProjectsAdmin}/>
      <AppRoute path="/admin/page-content"  layout={Admin} component={PageContentAdmin}/>
      <AppRoute path="/admin/skills" layout={Admin} component={SkillsAdmin}/>
      <AppRoute path="/admin/contact-messages" layout={Admin} component={ContactMessagesAdmin}/>


    </Router>
  );
}

export default App;
