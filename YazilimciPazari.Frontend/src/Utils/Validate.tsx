export function ValidateName(name:string) {
    const regex = /^[a-zA-ZğüşöçĞÜŞÖÇİı' -]+$/;
    return regex.test(name);
  }

export function ValidateEmail(email:string):boolean {
const regex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/;
return regex.test(email);
}

