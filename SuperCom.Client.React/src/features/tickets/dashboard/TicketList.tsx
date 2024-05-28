import { observer } from 'mobx-react-lite';
import { Fragment } from 'react';
import { Header } from "semantic-ui-react";
import { useStore } from '../../../app/stores/store';
import TicketListItem from './TicketListItem';

export default observer(function TicketList() {
    const { ticketStore } = useStore();
    const { groupedTickets } = ticketStore;

    return (
        <>
            {groupedTickets.map(([group, tickets]) => (
                <Fragment key={group}>
                    <Header sub color='red'>
                        {group}
                    </Header>
                    {tickets && tickets.map(ticket => (
                        <TicketListItem key={ticket.id} ticket={ticket} />
                    ))}
                </Fragment>
            ))}
        </>

    )
})
