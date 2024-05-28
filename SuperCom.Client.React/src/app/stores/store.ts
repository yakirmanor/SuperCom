import TicketStore from "./ticketStore";
import {createContext, useContext} from "react";
import CommonStore from "./commonStore";

interface Store {
    ticketStore: TicketStore;
    commonStore: CommonStore;
}

export const store: Store = {
    ticketStore: new TicketStore(),
    commonStore: new CommonStore()
}

export const StoreContext = createContext(store);

export function useStore() {
    return useContext(StoreContext);
}