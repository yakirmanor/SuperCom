import { observer } from "mobx-react-lite";
import { useEffect } from "react";
import { Grid } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";
import TicketFilters from "./TicketFilters";
import TicketList from './TicketList';

export default observer(function TicketDashboard() {
    const { ticketStore } = useStore();
    const { loadTickets, ticketRegistry } = ticketStore;

    useEffect(() => {
        if (ticketRegistry.size <= 1) loadTickets();
    }, [loadTickets, ticketRegistry.size])

    if (ticketStore.loadingInitial) return <LoadingComponent content='Loading app...' />

    return (
        <Grid>
            <Grid.Column width='10'>
                <TicketList />
            </Grid.Column>
            <Grid.Column width='6'>
                <TicketFilters />
            </Grid.Column>
        </Grid>
    )
})