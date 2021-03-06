export interface Configuration {
}

export class Config<T> {
  code: T;
  name: string;

  constructor(code: T, name: string) {
    this.code = code;
    this.name = name;
  }
}

export interface ProvinceConfig extends Config<string> {
  countryCode: string;
}
