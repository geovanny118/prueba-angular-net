import { Rol } from './rol';
export interface user {
    id?: number,
    name: string,
    lastname: string,
    birthdate: Date,
    civilStatus: string,
    hasBrothers: boolean,
    state: boolean,
    roles: Rol[] 
}