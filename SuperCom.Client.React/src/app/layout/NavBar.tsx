import {Button, Container, Menu} from "semantic-ui-react";
import { NavLink } from "react-router-dom";

export default function NavBar() {
    return (
        <Menu inverted fixed='top'>
            <Container>
                <Menu.Item as={NavLink} to='/' header>
                    <img src='/assets/supercom_logo.gif' alt='logo' style={{width: '130px'}} />
                </Menu.Item>
                <Menu.Item as={NavLink} to='/tickets' name='Tickets' />
                <Menu.Item as={NavLink} to='/errors' name='Errors' />
                <Menu.Item>
                    <Button as={NavLink} to='/createTicket' positive content='Create Ticket' />
                </Menu.Item>
            </Container>
        </Menu>
    )
}