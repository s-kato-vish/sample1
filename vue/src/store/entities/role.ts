import Entity from './entity'

export default class Role extends Entity<number>{
    public name:string;
    displayName:string;
    normalizedName:string;
    description:string;
    grantedPermissions:string[]
}