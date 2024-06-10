import { observer } from 'mobx-react-lite';
import React from 'react'
import { Link } from 'react-router-dom';
import { Button, Header, Item, Segment, Image, Label } from 'semantic-ui-react'
import {Ticket} from "../../../app/models/ticket";
import { useStore } from '../../../app/stores/store';

const ticketImageStyle = {
    filter: 'brightness(30%)'
};

const ticketImageTextStyle = {
    position: 'absolute',
    bottom: '5%',
    left: '5%',
    width: '100%',
    height: 'auto',
    color: 'white'
};

interface Props {
    ticket: Ticket
}

export default observer (function TicketDetailedHeader({ticket}: Props) {
    const { ticketStore } = useStore();

    return (
        <Segment.Group>
            <Segment basic attached='top' style={{padding: '0'}}>
                <Image src={`/assets/categoryImages/${ticket.category}.jpg`} fluid style={ticketImageStyle}/>
                <Segment style={ticketImageTextStyle} basic>
                    <Item.Group>
                        <Item>
                            <Item.Content>
                                <Header
                                    size='huge'
                                    content={ticket.name}
                                    style={{color: 'white'}}
                                />
                                <p>{ticket.date}</p>
                                <p>
                                Supervised by <strong>Bob</strong>
                                </p>
                            </Item.Content>
                        </Item>
                    </Item.Group>
                </Segment>
            </Segment>
            <Segment clearing attached='bottom'>
                <Button onClick={() => ticketStore.deleteTicket(ticket.id)} as={Link} to='/tickets' color='red'>Delete Ticket</Button>
                <Button as={Link} to={`/manage/${ticket.id}`} color='orange' floated='right'>Manage Event</Button>
            </Segment>
        </Segment.Group>
    )
})