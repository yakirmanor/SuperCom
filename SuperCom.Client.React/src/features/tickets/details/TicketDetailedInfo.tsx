import { observer } from 'mobx-react-lite';
import React from 'react'
import {Segment, Grid, Icon} from 'semantic-ui-react'
import {Ticket} from "../../../app/models/ticket";

interface Props {
    ticket: Ticket
}

export default observer(function TicketDetailedInfo({ticket}: Props) {
    return (
        <Segment.Group>
            <Segment attached='top'>
                <Grid>
                    <Grid.Column width={1}>
                        <Icon size='large' color='red' name='info'/>
                    </Grid.Column>
                    <Grid.Column width={15}>
                        <p>{ticket.description}</p>
                    </Grid.Column>
                </Grid>
            </Segment>
            <Segment attached>
                <Grid verticalAlign='middle'>
                    <Grid.Column width={1}>
                        <Icon name='calendar' size='large' color='red'/>
                    </Grid.Column>
                    <Grid.Column width={15}>
            <span>
              {ticket.date}
            </span>
                    </Grid.Column>
                </Grid>
            </Segment>
            <Segment attached>
                <Grid verticalAlign='middle'>
                    <Grid.Column width={1}>
                        <Icon name='marker' size='large' color='red'/>
                    </Grid.Column>
                    <Grid.Column width={11}>
                        <span>{ticket.location}, {ticket.city}</span>
                    </Grid.Column>
                </Grid>
            </Segment>
        </Segment.Group>
    )
})