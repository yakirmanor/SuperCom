import React from 'react'
import { Segment, List, Label, Item, Image } from 'semantic-ui-react'
import { Link } from 'react-router-dom'
import { observer } from 'mobx-react-lite'

export default observer(function TicketDetailedSidebar () {
    return (
        <>
            <Segment
                textAlign='center'
                style={{ border: 'none' }}
                attached='top'
                secondary
                inverted
                color='red'
            >
            Supervised by
            </Segment>
            <Segment attached>
                <List relaxed divided>
                    <Item style={{ position: 'relative' }}>
                        <Label
                            style={{ position: 'absolute' }}
                            color='orange'
                            ribbon='right'
                        >
                            Curret
                        </Label>
                        <Image size='tiny' src={'/assets/ticket.jpg'} />
                        <Item.Content verticalAlign='middle'>
                            <Item.Header as='h3'>
                                <Link to={`#`}>Bob</Link>
                            </Item.Header>
                            <Item.Extra style={{ color: 'orange' }}>Approved 28.05.2024</Item.Extra>
                        </Item.Content>
                    </Item>
                    <Item style={{ position: 'relative' }}>
                        <Image size='tiny' src={'/assets/ticket.jpg'} />
                        <Item.Content verticalAlign='middle'>
                            <Item.Header as='h3'>
                                <Link to={`#`}>Tom</Link>
                            </Item.Header>
                            <Item.Extra style={{ color: 'orange' }}>Approved 28.05.2023</Item.Extra>
                        </Item.Content>
                    </Item>
                </List>
            </Segment>
        </>

    )
})